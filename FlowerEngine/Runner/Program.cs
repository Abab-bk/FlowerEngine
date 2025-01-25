using FlowerEngine.Core;
using FlowerEngine.Core.Configs;
using Raylib_cs;

namespace Runner;

public static class Program
{
    public static void Main(string[] args)
    {
        var game = new Game(
            new GameSettings(),
            new WindowSettings(
                1280,
                720,
                "Flower Engine"
                )
            );
        
        game.Run();
    }
}

