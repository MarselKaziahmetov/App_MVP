using Core.Abstractions.MainWindow;
using System;

namespace Core.Modules.Gameplay
{
    public class MainWindowModel : IMainWindowModule
    {
        public bool IsHided => throw new NotImplementedException();

        public event Action HideRequested;
        public event Action ShowRequested;
    }
}
