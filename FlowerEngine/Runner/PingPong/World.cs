using System.Numerics;
using FlowerEngine.Core;
using Raylib_cs;

namespace Runner.PingPong;

public class World : Scene
{
    private readonly Player _player = new ();
    private readonly Enemy _enemy = new ();
    private readonly Ball _ball = new ();

    private bool _gameStarted;
    
    public override void OnActive()
    {
        base.OnActive();

        var texture = Raylib.LoadTexture("Content/Star.png");
        _player.Texture = texture;
        _enemy.Texture = texture;
        _ball.Texture = texture;
        
        _ball.Color = Color.Green;
        _enemy.Color = Color.Gold;

        _player.Position = new Vector2(50f, 50f);
        _enemy.Position = new Vector2(1000f, 50f);
        
        AddGameObject(_player);
        AddGameObject(_enemy);
        AddGameObject(_ball);
        
        ResetGame();
    }

    public override void Update(float delta)
    {
        base.Update(delta);
        _player.Y = Raylib.GetMouseY();

        if (!_gameStarted)
        {
            _ball.Position = _player.Position with { X = _player.Position.X + 50f };
        }

        if (_gameStarted)
        {
            if (_ball.Position.X >= 1280f || _ball.Position.X <= 0f ||
                _ball.Position.Y >= 720f || _ball.Position.Y <= 0f)
            {
                ResetGame();
            }

            if (_ball.Distance(_enemy.Position) < 50f)
            {
                _ball.Reverse();
            }
            
            if (_ball.Distance(_player.Position) < 50f)
            {
                _ball.Run();
            }
            
            _enemy.Y = _ball.Position.Y * 0.7f;
        }

        if (Raylib.IsMouseButtonPressed(MouseButton.Left))
        {
            if (_gameStarted)
            {
                ResetGame();
                return;
            }
            StartGame();
        }
    }

    private void ResetGame()
    {
        _gameStarted = false;
        
        _ball.Reset();
        _ball.Position = _player.Position with { X = _player.Position.X + 50f };
    }
    
    private void StartGame()
    {
        _gameStarted = true;
        _ball.Run();
    }
}
