using Raylib_cs;

namespace FlowerEngine.Core.GameObjects;

public class TransformableObject : GameObject
{
    public Transform Transform { get; set; } = new ();

    public float X
    {
        get => Transform.Translation.X;
        set => Transform = Transform with { Translation = Transform.Translation with { X = value } };
    }
    
    public float Y
    {
        get => Transform.Translation.Y;
        set => Transform = Transform with { Translation = Transform.Translation with { Y = value } };
    }
}