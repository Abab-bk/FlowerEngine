using FlowerEngine.Core.GameObjects;
using FlowerEngine.Core.Interfaces;

namespace FlowerEngine.Core;

public class Scene
{
    public readonly List<GameObject> GameObjects = new();
    
    public virtual void OnActive()
    {
    }
    
    public void AddGameObject(GameObject gameObject)
    {
        GameObjects.Add(gameObject);
    }
    
    public void RemoveGameObject(GameObject gameObject)
    {
        GameObjects.Remove(gameObject);
    }

    public virtual void Destroy()
    {
        foreach (var gameObject in GameObjects)
        {
            gameObject.Destroy();
        }
    }

    public virtual void Update(float delta)
    {
        foreach (var gameObject in GameObjects)
        {
            gameObject.Update(delta);
            gameObject.FixedUpdate(delta);

            if (gameObject is IDrawable drawable)
            {
                drawable.Draw();
            }
        }
    }
}