namespace FlowerEngine.Core.Configs;

public readonly struct ExitCode
{
    public readonly bool Restart = false;
    public ExitCode(bool restart) { Restart = restart; }
}