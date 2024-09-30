namespace FlowerEngine.Core.Interfaces;

public interface IUpdateable
{
    public void Update(float delta);
    public void FixedUpdate(float delta);
}