using System.Data;

namespace CodeCraft.Generators;

public class SqlProceduresSourceCodeGenerator : ISourceCodeGenerator
{
    public string Generate(DataTable dataTable)
    {
        string IdentifierName = dataTable.Rows[0][0].ToString()!;
        string IdentiferDataType = dataTable.Rows[0][1].ToString()!.ToUpper();

        string SingularEntityName = dataTable.TableName[..^1];

        string GetAllSqlProcedureString =
$@"
CREATE PROCEDURE usp_List{dataTable.TableName} AS
SELECT * FROM {dataTable.TableName}

-- usp_List{dataTable.TableName}

-- DROP PROCEDURE usp_List{dataTable.TableName} 
";

        string DeleteSqlProcedureString =
$@"
CREATE PROCEDURE usp_Delete{SingularEntityName} (@{IdentifierName} {IdentiferDataType}) AS
DELETE FROM {dataTable.TableName}
WHERE {IdentifierName} = @{IdentifierName}

-- usp_Delete{SingularEntityName} @{IdentifierName} = {(IdentiferDataType == "string" ? "'1'" : "1")}

-- DROP PROCEDURE usp_Delete{SingularEntityName} 
";

        string FindSqlProcedureString =
$@"
CREATE PROCEDURE usp_Find{SingularEntityName} (@{IdentifierName} {IdentiferDataType}) AS
SELECT * FROM {dataTable.TableName}
WHERE {IdentifierName} = @{IdentifierName}

-- usp_Find{SingularEntityName} @{IdentifierName} = {(IdentiferDataType == "string" ? "'1'" : "1")}

-- DROP PROCEDURE usp_Find{SingularEntityName} 
";


        return string.Join("-- =====================\n", 
            GetAllSqlProcedureString,
            FindSqlProcedureString,
            DeleteSqlProcedureString);
    }
}