using Core.Abstractions.SettingsWindow;
using System;
using UnityEngine;

namespace Core.Modules.Gameplay.SettingsWindow
{
    public class SettingsWindowModel : ISettingsWindowModule
    {
        private bool _isHided;

        public bool IsHided => _isHided;

        public event Action HideRequested;
        public event Action ShowRequested;

        public event Action<bool> MusicInitRequested;
        public event Action<bool> SoundInitRequested;

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
        public void SaveMusicVolumeToggle(bool value)
        {
            PlayerPrefs.SetInt("isMusicEnabled", value ? 1 : 0);
        }
        public void SaveSoundVolumeToggle(bool value)
        {
            PlayerPrefs.SetInt("isSoundEnabled", value ? 1 : 0);
        }
        public void InitMusicSettings()
        {
            var isMusicEnabled = PlayerPrefs.GetInt("isMusicEnabled") == 1 ? true : false;
            MusicInitRequested?.Invoke(isMusicEnabled);
        }
        public void InitSoundSettings()
        {
            var isSoundEnabled = PlayerPrefs.GetInt("isSoundEnabled") == 1 ? true : false;
            SoundInitRequested?.Invoke(isSoundEnabled);
        }
    }
}
