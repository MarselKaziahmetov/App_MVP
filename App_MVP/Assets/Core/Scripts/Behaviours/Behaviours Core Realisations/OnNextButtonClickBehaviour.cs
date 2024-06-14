using Core.Abstractions.Parametrs;
using Core.Abstractions.Sample;
using Core.Abstractions.SceneSwitcher;

namespace Core.Behaviours
{
    public class OnNextButtonClickBehaviour : IBehaviour
    {
        private readonly ISceneSwitcher _sceneSwitcher;
        private readonly IStartWindowModule _startWindow;
        private readonly ISceneParametrs _sceneParametrs;

        public OnNextButtonClickBehaviour(ISceneSwitcher sceneSwitcher, IStartWindowModule startWindow, ISceneParametrs sceneParametrs)
        {
            _sceneSwitcher = sceneSwitcher;
            _startWindow = startWindow;
            _sceneParametrs = sceneParametrs;
        }

        public void Enable()
        {
            _startWindow.MainSceneLoadRequested += SwitchScene;
        }

        private void SwitchScene()
        {
            _sceneSwitcher.SwitchSceneTo(_sceneParametrs.MainScene);
        }
    }
}
