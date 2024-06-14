using System;

namespace Core.Abstractions.SettingsWindow
{
    public interface ISettingsWindowModule
    {
        bool IsHided { get; }

        event Action HideRequested;
        event Action ShowRequested;
        event Action<bool> MusicInitRequested;
        event Action<bool> SoundInitRequested;
        event Action CloseButtonPressed;
        event Action<bool> MusicStateChanged;
        event Action<bool> SoundStateChanged;

        void ShowSettings();
        void HideSettings();
    }
}
