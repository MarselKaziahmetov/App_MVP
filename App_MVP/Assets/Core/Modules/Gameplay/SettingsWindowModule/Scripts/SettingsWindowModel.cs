using Core.Abstractions.SettingsWindow;
using System;

namespace Core.Modules.Gameplay.SettingsWindow
{
    public class SettingsWindowModel : ISettingsWindowModule
    {
        private bool _isHided;

        public bool IsHided => _isHided;

        public event Action HideRequested;
        public event Action ShowRequested;


        public void HideSettings()
        {
            _isHided = true;
            HideRequested?.Invoke();
        }
        public void ShowSettings()
        {
            _isHided = false;
            ShowRequested?.Invoke();
        }
    }
}
