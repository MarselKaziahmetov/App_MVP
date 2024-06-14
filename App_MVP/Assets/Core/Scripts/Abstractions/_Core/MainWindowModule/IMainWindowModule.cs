using System;

namespace Core.Abstractions.MainWindow
{
    public interface IMainWindowModule
    {
        bool IsHided { get; }

        event Action HideRequested;
        event Action ShowRequested;
    }
}
