namespace AreaShaper.Extensions;

public static class DoubleExtension
{
    public static bool IsEqualsToZero(this double fNum)
    {
        return fNum < double.Epsilon;
    }
}
