using UnityEngine.SceneManagement;
using System;

namespace Core.Abstractions.SceneSwitcher
{
    public interface ISceneSwitcher
    {
        event Action FadeInRequested;
        event Action FadeOutRequested;
        void SwitchSceneTo(string newScene);
        void LoadNewScene();
    }
}
