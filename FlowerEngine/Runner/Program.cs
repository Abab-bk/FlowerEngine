using FlowerEngine.Core;
using FlowerEngine.Core.Structs;

var game = new Game(
    new GameSettings(),
    new WindowSettings(
        1280,
        720,
        "Flower Engine"
        )
    );
game.Run();