using FlowerEngine.Core.Structs;
using Raylib_cs;

namespace FlowerEngine.Core;

public class Game
{
    #region StaticVars
    public static Game? Instance { get; private set; }
    
    #endregion

    #region PrivateVars

    private bool _quit;

    #endregion


    #region PublicVars

    public GameWindow Window { get; private set; }
    public Scene Scene { get; private set; }

    #endregion


    #region PublicMethods
    
    public Game(GameSettings gameSettings, WindowSettings windowSettings, Scene scene)
    {
        Window = new GameWindow(windowSettings);
        Instance = this;
        Scene = scene;
        
        Scene.OnActive();
    }

    public void SetScene(Scene scene)
    {
        Scene.Destroy();
        Scene = scene;
        Scene.OnActive();
    }

    public ExitCode Run()
    {
        _quit = false;
        
        SetExitKey(KeyboardKey.Null);
        
        StartGameLoop();
        RunGameLoop();
        EndGameLoop();
        
        CloseWindow();
        
        return new ExitCode(false);
    }
    
    #endregion
    

    #region PrivateMethods

    private void StartGameLoop()
    {
        RunBefore();
    }

    private void EndGameLoop()
    {
        EndBefore();
        
        Scene.Destroy();
    }

    private void RunGameLoop()
    {
        while (!_quit)
        {
            if (WindowShouldClose())
            {
                Quit();
                continue;
            }

            BeginDrawing();
            ClearBackground(Color.Black);
            
            var delta = GetFrameTime();
            Window.Update(delta);
            Scene.Update(delta);
            
            EndDrawing();
        }
    }
    
    private void Quit()
    {
        _quit = true;
    }

    #endregion

    #region VirtualMethods

    protected virtual void RunBefore()
    {
    }
    
    protected virtual void EndBefore()
    {
    }
    
    #endregion
}