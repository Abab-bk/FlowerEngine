using FlowerEngine.Core.Interfaces;
using Raylib_cs;

namespace FlowerEngine.Core.GameObjects;

public class GameObject2D : TransformableObject, IDrawable
{
    public Color Color = Color.White;
    
    public virtual void Draw()
    {
    }
}