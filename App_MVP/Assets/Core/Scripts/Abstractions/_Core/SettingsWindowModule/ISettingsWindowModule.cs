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

        void ShowSettings();
        void HideSettings();
    }
}
