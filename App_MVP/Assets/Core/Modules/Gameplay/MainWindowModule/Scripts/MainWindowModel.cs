using Core.Abstractions.MainWindow;
using System;

namespace Core.Modules.Gameplay.MainWindow
{
    public class MainWindowModel : IMainWindowModule
    {
        private bool _isHided;

        public bool IsHided => _isHided;

        public event Action HideRequested;
        public event Action ShowRequested;

        public event Action MainSceneLoadRequested;
        public event Action SettingsWindowRequested;

        internal void HideView()
        {
            _isHided = true;
            HideRequested?.Invoke();
        }
        internal void ShowView()
        {
            _isHided = false;
            ShowRequested?.Invoke();
        }
        internal void LoadMainScene()
        {
            HideView();
            MainSceneLoadRequested?.Invoke();
        }
        internal void ShowSettings()
        {
            SettingsWindowRequested?.Invoke();
        }
    }
}
