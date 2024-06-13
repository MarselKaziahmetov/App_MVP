using Core.Abstractions.Sample;
using System;

namespace Core.Modules.Gameplay.SampleModule
{
    public class SampleModuleModel : ISampleModule
    {
        private bool _isHided;

        public bool IsHided => _isHided;

        public event Action HideRequested;
        public event Action ShowRequested;

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
    }
}
