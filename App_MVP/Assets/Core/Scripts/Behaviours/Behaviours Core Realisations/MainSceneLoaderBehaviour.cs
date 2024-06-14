using Core.Abstractions.MainWindow;
using Core.Abstractions.Parametrs;
using Core.Abstractions.Sample;
using Core.Abstractions.SceneSwitcher;

namespace Core.Behaviours
{
    public class MainSceneLoaderBehaviour : IBehaviour
    {
        private readonly ISceneSwitcher _sceneSwitcher;
        private readonly IStartWindowModule _startWindow;
        private readonly IMainWindowModule _mainWindow;
        private readonly ISceneParametrs _sceneParametrs;

        public MainSceneLoaderBehaviour(ISceneSwitcher sceneSwitcher, IStartWindowModule startWindow, 
            ISceneParametrs sceneParametrs, IMainWindowModule mainWindow)
        {
            _sceneSwitcher = sceneSwitcher;
            _startWindow = startWindow;
            _sceneParametrs = sceneParametrs;
            _mainWindow = mainWindow;
        }

        public void Enable()
        {
            _startWindow.MainSceneLoadRequested += SwitchScene;
            _mainWindow.MainSceneLoadRequested += SwitchScene;
        }

        private void SwitchScene()
        {
            _sceneSwitcher.SwitchSceneTo(_sceneParametrs.MainScene);
        }
    }
}
