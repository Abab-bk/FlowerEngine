namespace FlowerEngine.Core.Structs;

public struct WindowSettings(int width, int height, string title)
{
    public int Width = width;
    public int Height = height;
    public string Title = title;
}