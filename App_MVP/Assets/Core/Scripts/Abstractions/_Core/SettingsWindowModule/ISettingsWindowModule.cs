using System;

namespace Core.Abstractions.SettingsWindow
{
    public interface ISettingsWindowModule
    {
        bool IsHided { get; }

        event Action HideRequested;
        event Action ShowRequested;

        void ShowSettings();
        void HideSettings();
    }
}
