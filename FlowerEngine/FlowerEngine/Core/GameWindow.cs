using FlowerEngine.Core.Structs;
using Raylib_cs;

namespace FlowerEngine.Core;

public sealed class GameWindow
{
    public static GameWindow? Instance { get; private set; }
    
    internal GameWindow(WindowSettings windowSettings)
    {
        Raylib.InitWindow(windowSettings.Width, windowSettings.Height, windowSettings.Title);
        Instance = this;
    }

    internal void Update(float delta)
    {
        
    }
}