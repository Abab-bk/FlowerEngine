namespace FlowerEngine.Core.Extensions;

public static class RandomExtension
{
    public static float NextFloat(this Random random, float minValue, float maxValue) => 
        (float)(random.NextDouble() * (maxValue - minValue) + minValue);
}