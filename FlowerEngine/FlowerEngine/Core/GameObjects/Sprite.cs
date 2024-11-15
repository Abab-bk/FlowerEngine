using FlowerEngine.Core.Extensions;
using Raylib_cs;

namespace FlowerEngine.Core.GameObjects;

public class Sprite : GameObject2D
{
    public Texture2D Texture { get; set; }

    public override void Draw()
    {
        if (!IsTextureReady(Texture)) return;
        DrawTextureEx(
            Texture,
            Transform.ToPositionVector2(),
            Transform.Rotation.W,
            1f,
            Color
            );
    }

    public override void Destroy()
    {
        base.Destroy();
        UnloadTexture(Texture);
    }
}