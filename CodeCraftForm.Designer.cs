namespace CodeCraft;

partial class CodeCraftForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        textBoxTableName = new TextBox();
        label1 = new Label();
        tabControl1 = new TabControl();
        tabPageSchema = new TabPage();
        dataGridViewSchema = new DataGridView();
        tabPageModel = new TabPage();
        buttonCopyModelToClipboard = new Button();
        textBoxModelCode = new TextBox();
        tabPageSqlProcedures = new TabPage();
        buttonCopySqlProceduresToClipboard = new Button();
        textBoxSqlProceduresCode = new TextBox();
        buttonGenerate = new Button();
        comboBoxConnectionString = new ComboBox();
        label2 = new Label();
        tabControl1.SuspendLayout();
        tabPageSchema.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridViewSchema).BeginInit();
        tabPageModel.SuspendLayout();
        tabPageSqlProcedures.SuspendLayout();
        SuspendLayout();
        // 
        // textBoxTableName
        // 
        textBoxTableName.Location = new Point(121, 17);
        textBoxTableName.Margin = new Padding(8);
        textBoxTableName.Name = "textBoxTableName";
        textBoxTableName.Size = new Size(200, 27);
        textBoxTableName.TabIndex = 0;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(17, 17);
        label1.Margin = new Padding(8);
        label1.Name = "label1";
        label1.Size = new Size(88, 20);
        label1.TabIndex = 1;
        label1.Text = "Table Name";
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(tabPageSchema);
        tabControl1.Controls.Add(tabPageModel);
        tabControl1.Controls.Add(tabPageSqlProcedures);
        tabControl1.Location = new Point(17, 121);
        tabControl1.Margin = new Padding(8);
        tabControl1.Name = "tabControl1";
        tabControl1.Padding = new Point(0, 0);
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(766, 312);
        tabControl1.TabIndex = 2;
        // 
        // tabPageSchema
        // 
        tabPageSchema.Controls.Add(dataGridViewSchema);
        tabPageSchema.Location = new Point(4, 29);
        tabPageSchema.Name = "tabPageSchema";
        tabPageSchema.Padding = new Padding(3);
        tabPageSchema.Size = new Size(758, 279);
        tabPageSchema.TabIndex = 0;
        tabPageSchema.Text = "Schema";
        tabPageSchema.UseVisualStyleBackColor = true;
        // 
        // dataGridViewSchema
        // 
        dataGridViewSchema.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewSchema.Location = new Point(0, 0);
        dataGridViewSchema.Name = "dataGridViewSchema";
        dataGridViewSchema.RowHeadersWidth = 51;
        dataGridViewSchema.RowTemplate.Height = 29;
        dataGridViewSchema.Size = new Size(758, 279);
        dataGridViewSchema.TabIndex = 0;
        // 
        // tabPageModel
        // 
        tabPageModel.Controls.Add(buttonCopyModelToClipboard);
        tabPageModel.Controls.Add(textBoxModelCode);
        tabPageModel.Location = new Point(4, 29);
        tabPageModel.Name = "tabPageModel";
        tabPageModel.Size = new Size(758, 279);
        tabPageModel.TabIndex = 2;
        tabPageModel.Text = "Model";
        tabPageModel.UseVisualStyleBackColor = true;
        // 
        // buttonCopyModelToClipboard
        // 
        buttonCopyModelToClipboard.Location = new Point(558, 16);
        buttonCopyModelToClipboard.Margin = new Padding(16, 16, 8, 8);
        buttonCopyModelToClipboard.Name = "buttonCopyModelToClipboard";
        buttonCopyModelToClipboard.Padding = new Padding(8);
        buttonCopyModelToClipboard.Size = new Size(163, 44);
        buttonCopyModelToClipboard.TabIndex = 6;
        buttonCopyModelToClipboard.Text = "Copy To Clipboard";
        buttonCopyModelToClipboard.UseVisualStyleBackColor = true;
        buttonCopyModelToClipboard.Click += buttonCopyModelToClipboard_Click;
        // 
        // textBoxModelCode
        // 
        textBoxModelCode.Font = new Font("Consolas", 10F, FontStyle.Italic, GraphicsUnit.Point);
        textBoxModelCode.Location = new Point(-4, 0);
        textBoxModelCode.Multiline = true;
        textBoxModelCode.Name = "textBoxModelCode";
        textBoxModelCode.ScrollBars = ScrollBars.Vertical;
        textBoxModelCode.Size = new Size(762, 279);
        textBoxModelCode.TabIndex = 0;
        // 
        // tabPageSqlProcedures
        // 
        tabPageSqlProcedures.Controls.Add(buttonCopySqlProceduresToClipboard);
        tabPageSqlProcedures.Controls.Add(textBoxSqlProceduresCode);
        tabPageSqlProcedures.Location = new Point(4, 29);
        tabPageSqlProcedures.Name = "tabPageSqlProcedures";
        tabPageSqlProcedures.Size = new Size(758, 279);
        tabPageSqlProcedures.TabIndex = 3;
        tabPageSqlProcedures.Text = "SQL Procedures";
        tabPageSqlProcedures.UseVisualStyleBackColor = true;
        // 
        // buttonCopySqlProceduresToClipboard
        // 
        buttonCopySqlProceduresToClipboard.Location = new Point(558, 16);
        buttonCopySqlProceduresToClipboard.Margin = new Padding(16, 16, 8, 8);
        buttonCopySqlProceduresToClipboard.Name = "buttonCopySqlProceduresToClipboard";
        buttonCopySqlProceduresToClipboard.Padding = new Padding(8);
        buttonCopySqlProceduresToClipboard.Size = new Size(163, 44);
        buttonCopySqlProceduresToClipboard.TabIndex = 5;
        buttonCopySqlProceduresToClipboard.Text = "Copy To Clipboard";
        buttonCopySqlProceduresToClipboard.UseVisualStyleBackColor = true;
        buttonCopySqlProceduresToClipboard.Click += buttonCopyToClipboard_Click;
        // 
        // textBoxSqlProceduresCode
        // 
        textBoxSqlProceduresCode.Font = new Font("Consolas", 10F, FontStyle.Italic, GraphicsUnit.Point);
        textBoxSqlProceduresCode.Location = new Point(-4, 0);
        textBoxSqlProceduresCode.Multiline = true;
        textBoxSqlProceduresCode.Name = "textBoxSqlProceduresCode";
        textBoxSqlProceduresCode.ScrollBars = ScrollBars.Vertical;
        textBoxSqlProceduresCode.Size = new Size(762, 279);
        textBoxSqlProceduresCode.TabIndex = 1;
        // 
        // buttonGenerate
        // 
        buttonGenerate.Location = new Point(657, 61);
        buttonGenerate.Margin = new Padding(8);
        buttonGenerate.Name = "buttonGenerate";
        buttonGenerate.Padding = new Padding(8);
        buttonGenerate.Size = new Size(122, 44);
        buttonGenerate.TabIndex = 1;
        buttonGenerate.Text = "Generate";
        buttonGenerate.UseVisualStyleBackColor = true;
        buttonGenerate.Click += buttonGenerate_Click;
        // 
        // comboBoxConnectionString
        // 
        comboBoxConnectionString.FormattingEnabled = true;
        comboBoxConnectionString.Items.AddRange(new object[] { "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Invee_Db;Trusted_Connection=True", "Data Source=DESKTOP-JPLKMLT\\SQLEXPRESS;Initial Catalog=JoyZone_Db;Trusted_Connection=True" });
        comboBoxConnectionString.Location = new Point(579, 17);
        comboBoxConnectionString.Margin = new Padding(8);
        comboBoxConnectionString.Name = "comboBoxConnectionString";
        comboBoxConnectionString.Size = new Size(200, 28);
        comboBoxConnectionString.TabIndex = 3;
        comboBoxConnectionString.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(436, 20);
        label2.Margin = new Padding(8);
        label2.Name = "label2";
        label2.Size = new Size(127, 20);
        label2.TabIndex = 4;
        label2.Text = "Connection String";
        // 
        // CodeCraftForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(label2);
        Controls.Add(comboBoxConnectionString);
        Controls.Add(buttonGenerate);
        Controls.Add(tabControl1);
        Controls.Add(label1);
        Controls.Add(textBoxTableName);
        Name = "CodeCraftForm";
        Text = "CodeCraftForm";
        tabControl1.ResumeLayout(false);
        tabPageSchema.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridViewSchema).EndInit();
        tabPageModel.ResumeLayout(false);
        tabPageModel.PerformLayout();
        tabPageSqlProcedures.ResumeLayout(false);
        tabPageSqlProcedures.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox textBoxTableName;
    private Label label1;
    private TabControl tabControl1;
    private TabPage tabPageSchema;
    private TabPage tabPageModel;
    private DataGridView dataGridViewSchema;
    private Button buttonGenerate;
    private ComboBox comboBoxConnectionString;
    private Label label2;
    private TextBox textBoxModelCode;
    private TabPage tabPageSqlProcedures;
    private TextBox textBoxSqlProceduresCode;
    private Button buttonCopySqlProceduresToClipboard;
    private Button buttonCopyModelToClipboard;
}
