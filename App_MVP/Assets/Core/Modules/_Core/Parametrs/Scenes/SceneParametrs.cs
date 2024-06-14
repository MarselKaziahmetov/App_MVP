using Core.Abstractions.Parametrs;
using Core.Modules.Core.Parametrs;
using UnityEngine.SceneManagement;

namespace Core.Modules.Core
{
    public class SceneParametrs : ISceneParametrs
    {
        public string MainScene { get; }
        public string StartScene { get; }

        public SceneParametrs(SceneParametrsSettings sceneParametrsSettings)
        {
            MainScene = sceneParametrsSettings.MainScene;
            StartScene = sceneParametrsSettings.StartScene;
        }
    }
}
