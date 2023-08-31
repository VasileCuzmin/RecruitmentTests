using DiamondKata.Abstractions;
using System.Text;

namespace DiamondKata.Strategies;

public class C_Strategy: IDiamondKataStrategy
{
    public string Execute()
    {
        var sb = new StringBuilder();
        sb.Append("__A__");
        sb.Append("\n");
        sb.Append("_B_B_");
        sb.Append("\n");
        sb.Append("C___C");
        sb.Append("\n");
        sb.Append("_B_B_");
        sb.Append("\n");
        sb.Append("__A__");
        return sb.ToString();
    }
}