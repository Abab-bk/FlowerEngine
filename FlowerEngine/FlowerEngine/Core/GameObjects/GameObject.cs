using FlowerEngine.Core.Interfaces;

namespace FlowerEngine.Core.GameObjects;

public abstract class GameObject : IUpdateable
{
    public virtual void Update(float delta)
    {
    }

    public virtual void FixedUpdate(float delta)
    {
    }

    public virtual void Destroy()
    {
    }
}