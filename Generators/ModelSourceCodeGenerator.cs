using System.Data;

namespace CodeCraft.Generators;

public class ModelSourceCodeGenerator : ISourceCodeGenerator
{
    public string Generate(DataTable dataTable)
    {
        List<string> classFields = new();

        foreach (DataRow row in dataTable.Rows)
        {
            var columnName = ((string)row["ColumnName"]);
            var dataType = GetColumnDataType(row);

            classFields.Add($"public {dataType} {columnName} {{ get; set; }}");
        }

        return $@"
public class {dataTable.TableName[..^1]} 
{{
    {string.Join("\r\n    ", classFields).TrimStart()}
}}";
    }

    private static string GetColumnDataType(DataRow row)
    {
        var dataType = (string)row["DataType"];
        short maximumLength = (short)row["MaximumLength"];
        byte scale = (byte)row["Scale"];

        if (dataType.Contains("varchar") || dataType.Contains("text"))
            return "string";

        if (scale > 0)
            return "decimal";

        else
            return maximumLength > 4 ? "long" : "int";
    }
}
