using System.Numerics;
using FlowerEngine.Core.Extensions;
using Raylib_cs;

namespace FlowerEngine.Core.GameObjects;

public class TransformableObject : GameObject
{
    public Transform Transform { get; set; } = new();

    public Vector2 Position
    {
        get => Transform.ToPositionVector2();
        set => Transform = Transform with
        {
            Translation = Transform.Translation with
            {
                X = value.X,
                Y = value.Y
            }
        };
    }

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

    public override void Update(float delta)
    {
        UpdateTransform(delta);
    }
    
    public override void FixedUpdate(float delta)
    {
        UpdateTransform(delta);
    }

    private void UpdateTransform(float delta)
    {
        foreach (var child in Children)
        {
            child.Update(delta);
            if (child is TransformableObject transformableObject)
            {
                transformableObject.Transform = 
                    transformableObject.Transform with
                    {
                        Translation = transformableObject.Transform.Translation + Transform.Translation
                    };
            }
        }
    }
}