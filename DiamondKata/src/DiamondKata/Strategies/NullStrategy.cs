using DiamondKata.Abstractions;

namespace DiamondKata.Strategies;

internal class NullStrategy: IDiamondKataStrategy
{
    public string Execute() => string.Empty;
}