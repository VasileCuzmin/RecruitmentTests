using DiamondKata.Abstractions;
using DiamondKata.Strategies;

namespace DiamondKata;

public class DiamondKata
{
    //In a real project this dictionary would be injected into DI using reflection
    public static Dictionary<char, IDiamondKataStrategy> KataStrategies { get; } =
        new()
        {
            { 'A', new A_Strategy() },
            { 'B', new B_Strategy() },
            { 'C', new C_Strategy() }
        };

    //In a real project this dictionary would be injected into DI as a func delegate
    private readonly Func<char, IDiamondKataStrategy> _kataStrategiesSelector = character =>
    {
        if (KataStrategies.TryGetValue(character, out var strategy))
        {
            return strategy;
        }

        return new NullStrategy();
    };

    //public string GetDiamondKata(char middleCharacter)
    //{
    //    return string.Empty;
    //}

    //public string GetDiamondKata(char middleCharacter)
    //{
    //    if (middleCharacter == '\0')
    //    {
    //        return string.Empty;
    //    }

    //    if (middleCharacter == 'A')
    //    {
    //        return "__A__";
    //    }

    //    if (middleCharacter == 'B')
    //    {
    //        var sb = new StringBuilder();
    //        sb.Append("__A__");
    //        sb.Append("\n");
    //        sb.Append("_B_B_");
    //        sb.Append("\n");
    //        sb.Append("__A__");
    //        return sb.ToString();
    //    }

    //    return string.Empty;
    //}

    //public string GetDiamondKata(char middleCharacter)
    //{
    //    if (middleCharacter == '\0')
    //    {
    //        return string.Empty;
    //    }

    //    if (middleCharacter == 'A')
    //    {
    //        return "__A__";
    //    }

    //    if (middleCharacter == 'B')
    //    {
    //        var sb = new StringBuilder();
    //        sb.Append("__A__");
    //        sb.Append("\n");
    //        sb.Append("_B_B_");
    //        sb.Append("\n");
    //        sb.Append("__A__");
    //        return sb.ToString();
    //    }

    //    if (middleCharacter == 'C')
    //    {
    //        var sb = new StringBuilder();
    //        sb.Append("__A__");
    //        sb.Append("\n");
    //        sb.Append("_B_B_");
    //        sb.Append("\n");
    //        sb.Append("C___C");
    //        sb.Append("\n");
    //        sb.Append("_B_B_");
    //        sb.Append("\n");
    //        sb.Append("__A__");
    //        return sb.ToString();
    //    }

    //    return string.Empty;
    //}

    //public string GetDiamondKata(char middleCharacter)
    //{
    //    if (middleCharacter == 'A')
    //    {
    //        return "__A__";
    //    }

    //    if (middleCharacter == 'B')
    //    {
    //        var sb = new StringBuilder();
    //        sb.Append("__A__");
    //        sb.Append("\n");
    //        sb.Append("_B_B_");
    //        sb.Append("\n");
    //        sb.Append("__A__");
    //        return sb.ToString();
    //    }

    //    if (middleCharacter == 'C')
    //    {
    //        var sb = new StringBuilder();
    //        sb.Append("__A__");
    //        sb.Append("\n");
    //        sb.Append("_B_B_");
    //        sb.Append("\n");
    //        sb.Append("C___C");
    //        sb.Append("\n");
    //        sb.Append("_B_B_");
    //        sb.Append("\n");
    //        sb.Append("__A__");
    //        return sb.ToString();
    //    }

    //    return string.Empty;
    //}

    public string GetDiamondKata(char middleCharacter)
    {
        return _kataStrategiesSelector.Invoke(middleCharacter).Execute();
    }

    //What if the user decide to introduce another character? Then the user would change the method every time...We do not want that
    //We must adhere to the OCP principle - so we should introduce Strategy Design pattern without breaking the tests done so far! 
}