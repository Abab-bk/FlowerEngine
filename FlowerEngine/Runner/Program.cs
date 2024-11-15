using FlowerEngine.Core;
using FlowerEngine.Core.GameObjects;
using FlowerEngine.Core.Structs;
using Raylib_cs;
using Runner.PingPong;

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
                ),
            new World()
            );
        
        game.Run();
    }
}

