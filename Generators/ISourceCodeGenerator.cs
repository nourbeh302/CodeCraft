using System.Data;

namespace CodeCraft.Generators;

public interface ISourceCodeGenerator
{
    public string Generate(DataTable dataTable);
}
