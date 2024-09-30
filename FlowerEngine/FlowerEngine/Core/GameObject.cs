using FlowerEngine.Core.Interfaces;

namespace FlowerEngine.Core;

public class GameObject : IUpdateable
{
    public void Update(float delta)
    {
        throw new NotImplementedException();
    }

    public void FixedUpdate(float delta)
    {
        throw new NotImplementedException();
    }
}