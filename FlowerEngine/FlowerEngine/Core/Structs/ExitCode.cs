namespace FlowerEngine.Core.Structs;

public readonly struct ExitCode
{
    public readonly bool Restart = false;
    public ExitCode(bool restart) { this.Restart = restart; }
}