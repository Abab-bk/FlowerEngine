using FlowerEngine.Core;
using FlowerEngine.Core.GameObjects;
using FlowerEngine.Core.Structs;
using Raylib_cs;

namespace Runner;

public static class Program
{
    public class TestScene : Scene
    {
        private readonly Sprite _sprite = new ();
        
        public override void OnEnterWorld()
        {
            base.OnEnterWorld();
            _sprite.Texture = Raylib.LoadTexture("Content/Star.png");
            AddGameObject(_sprite);
        }

        public override void Update(float delta)
        {
            base.Update(delta);
            _sprite.X += 60f * delta;
            
            if (_sprite.X > 1280f)
            {
                _sprite.X = 0f;
            }
        }
    }
    
    public static void Main(string[] args)
    {
        var scene = new TestScene();
        
        var game = new Game(
            new GameSettings(),
            new WindowSettings(
                1280,
                720,
                "Flower Engine"
                ),
            scene
            );
        
        game.Run();
    }
}

