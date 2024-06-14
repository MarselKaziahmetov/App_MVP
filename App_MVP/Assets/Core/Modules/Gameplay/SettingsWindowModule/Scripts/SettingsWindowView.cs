using Core.Abstractions.MVP;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Core.Modules.Gameplay.SettingsWindow
{
    public class SettingsWindowView : UIPopUp
    {
        #region Variables
        [SerializeField] private Toggle _musicToggle;
        [SerializeField] private Toggle _soundToggle;
        [SerializeField] private Button _closeButton;

        public event Action CloseButtonPressed;
        public event Action<bool> SoundTogglePressed;
        public event Action<bool> MusicTogglePressed;
        #endregion

        #region Unity lifecycle
        private void OnEnable()
        {
            _closeButton.onClick.AddListener(OnCloseButtonClick);
            _musicToggle.onValueChanged.AddListener(OnMusicToggleValueChanged);
            _soundToggle.onValueChanged.AddListener(OnSoundToggleValueChanged);
        }
        private void OnDisable()
        {
            _closeButton.onClick.RemoveAllListeners();
            _musicToggle.onValueChanged.RemoveAllListeners();
            _soundToggle.onValueChanged.RemoveAllListeners();
        }

        private void Start()
        {
            InitHidedPopUp();
        }
        #endregion


        #region Public methods
        internal void HideView()
        {
            Hide_DropOutFadeOut();
        }
        internal void ShowView()
        {
            Show_DropOutFadeOut();
        }
        #endregion


        #region Private methods
        private void OnCloseButtonClick()
        {
            CloseButtonPressed?.Invoke();
        }
        private void OnSoundToggleValueChanged(bool value)
        {
            SoundTogglePressed?.Invoke(value);
        }
        private void OnMusicToggleValueChanged(bool value)
        {
            MusicTogglePressed?.Invoke(value);
        }
        #endregion
    }
}