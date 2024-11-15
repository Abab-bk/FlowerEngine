using FlowerEngine.Core.Interfaces;

namespace FlowerEngine.Core.GameObjects;

public abstract class GameObject : IUpdateable
{
    public readonly List<GameObject> Children = new ();

    public void AddChild(GameObject gameObject)
    {
        Children.Add(gameObject);
    }
    
    public void RemoveChild(GameObject gameObject)
    {
        Children.Remove(gameObject);
    }

    public virtual void Update(float delta)
    {
        foreach (var child in Children)
        {
            child.Update(delta);
        }
    }

    public virtual void FixedUpdate(float delta)
    {
        foreach (var child in Children)
        {
            child.FixedUpdate(delta);
        }
    }

    public virtual void OnCreate()
    {
    }
    
    public virtual void Destroy()
    {
    }
}