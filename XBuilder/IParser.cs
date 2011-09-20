using System;
namespace XBuilder
{
    public interface IParser
    {
        double Compute();
        void LoadVariables(System.Data.DataTable source);
        string Parse(string expression);
    }
}
