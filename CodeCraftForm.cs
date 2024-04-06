using CodeCraft.Generators;
using System.Data;
using System.Data.SqlClient;

namespace CodeCraft;

public partial class CodeCraftForm : Form
{
    private string _connectionString;

    public CodeCraftForm()
    {
        InitializeComponent();
        _connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Invee_Db;Trusted_Connection=True";
        comboBoxConnectionString.Text = _connectionString;
    }

    private void buttonGenerate_Click(object sender, EventArgs e)
    {
        string tableName = textBoxTableName.Text;

        string query = $"""
            SELECT 
                c.name AS ColumnName,
                t.name AS DataType,
                c.max_length AS MaximumLength,
                c.scale AS Scale,
                c.precision AS Precision,
                c.is_nullable AS IsNull,
                CASE WHEN ic.column_id IS NOT NULL THEN 1 ELSE 0 END AS IsPrimaryKey,
                CASE WHEN fc.column_id IS NOT NULL THEN 1 ELSE 0 END AS IsForeignKey,
                CASE WHEN c.is_identity = 1 THEN 1 ELSE 0 END AS IsIdentity
            FROM sys.columns c
            JOIN sys.types t ON c.user_type_id = t.user_type_id
            LEFT JOIN (
                SELECT ic.object_id, column_id
                FROM sys.indexes i
                JOIN sys.index_columns ic ON i.object_id = ic.object_id AND i.index_id = ic.index_id
                WHERE i.is_primary_key = 1
            ) ic ON c.object_id = ic.object_id AND c.column_id = ic.column_id
            LEFT JOIN (
                SELECT parent_object_id, parent_column_id AS column_id
                FROM sys.foreign_key_columns
            ) fc ON c.object_id = fc.parent_object_id AND c.column_id = fc.column_id
            WHERE c.object_id = OBJECT_ID('{tableName}');
            """;

        if (string.IsNullOrWhiteSpace(tableName))
        {
            MessageBox.Show("Please provide table name");
        }
        else
        {
            using SqlConnection connection = new(_connectionString);

            try
            {
                DataTable dataTable = new();
                SqlDataAdapter dataAdapter = new(query, connection);

                connection.Open();
                dataAdapter.Fill(dataTable);

                dataTable.TableName = tableName;
                dataGridViewSchema.DataSource = dataTable;

                loadTextboxesByDataTable(dataTable);

                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.StartsWith("Invalid object name")
                    ? "No table name found in the database provided." :
                    ex.Message);
            }
        }
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        _connectionString = comboBoxConnectionString.Text;
    }

    private void buttonCopyToClipboard_Click(object sender, EventArgs e)
    {
        Clipboard.SetText(textBoxSqlProceduresCode.Text);
    }

    private void buttonCopyModelToClipboard_Click(object sender, EventArgs e)
    {
        Clipboard.SetText(textBoxModelCode.Text);
    }

    private void loadTextboxesByDataTable(DataTable dataTable)
    {
        ModelSourceCodeGenerator modelGenerator = new ModelSourceCodeGenerator();
        textBoxModelCode.Text = modelGenerator.Generate(dataTable);

        SqlProceduresSourceCodeGenerator procedureGenerator = new SqlProceduresSourceCodeGenerator();
        textBoxSqlProceduresCode.Text = procedureGenerator.Generate(dataTable);
    }
}
