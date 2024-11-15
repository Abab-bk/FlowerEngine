using System.Numerics;
using FlowerEngine.Core.Extensions;
using FlowerEngine.Core.GameObjects;

namespace Runner.PingPong;

public class Ball : Sprite
{
    private Vector2 _velocity = Vector2.One;
    private bool _run;
    
    public void Reset()
    {
        _run = false;
    }
    
    public void Run()
    {
        _run = true;
        _velocity = new Vector2(
            Random.Shared.NextFloat(10f, 20f),
            Random.Shared.NextFloat(-10f, 10f)
            );
    }

    public void Reverse()
    {
        _velocity = new Vector2(
            Random.Shared.NextFloat(-10f, -20f),
            Random.Shared.NextFloat(-10f, 10f)
        );
    }

    public override void Update(float delta)
    {
        base.Update(delta);
        if (!_run) return;
        Position += Vector2.Normalize(_velocity) * delta * 600f;
    }
}