using System.Numerics;
using FlowerEngine.Core.Interfaces;
using Raylib_cs;

namespace FlowerEngine.Core.GameObjects;

public class GameObject2D : TransformableObject, IDrawable
{
    public Color Color = Color.White;
    public bool Visible = true;
    
    public virtual void Draw()
    {
        if (!Visible) return;
        foreach (var child in Children)
        {
            if (child is IDrawable drawable)
            {
                drawable.Draw();
            }
        }
    }
    
    public float Distance(Vector2 position) => Vector2.Distance(Position, position);
}