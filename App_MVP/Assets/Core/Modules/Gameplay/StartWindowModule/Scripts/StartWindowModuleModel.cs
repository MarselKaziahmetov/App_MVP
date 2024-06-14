using Core.Abstractions.Sample;
using System;

namespace Core.Modules.Gameplay.SampleModule
{
    public class StartWindowModuleModel : IStartWindowModule
    {
        private bool _isHided;

        public bool IsHided => _isHided;

        public event Action HideRequested;
        public event Action ShowRequested;
        public event Action MainSceneLoadRequested;

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
    }
}
