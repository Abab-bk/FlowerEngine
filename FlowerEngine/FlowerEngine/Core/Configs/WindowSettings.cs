namespace FlowerEngine.Core.Configs;

public class WindowSettings(int width, int height, string title)
{
    public int Width { get; set; } = width;
    public int Height { get; set; } = height;
    public string Title { get; set; } = title;
}