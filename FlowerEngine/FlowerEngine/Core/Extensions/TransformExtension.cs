using System.Numerics;
using Raylib_cs;

namespace FlowerEngine.Core.Extensions;

public static class TransformExtension
{
    public static Vector2 ToPositionVector2(this Transform transform)
    {
        return new Vector2(x: transform.Translation.X, y: transform.Translation.Y);
    }
}