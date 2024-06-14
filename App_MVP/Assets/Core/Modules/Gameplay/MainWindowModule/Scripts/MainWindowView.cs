using Core.Abstractions.MVP;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Core.Modules.Gameplay.MainWindow
{
    public class MainWindowView : UIPopUp
    {
        #region Variables
        [SerializeField] private Button _settingsButton;
        [SerializeField] private Button _restartButton;

        public event Action SettingsButtonPressed;
        public event Action RestartButtonPressed;
        #endregion

        #region Unity lifecycle
        private void OnEnable()
        {
            _restartButton.onClick.AddListener(OnRestartButtonClick);
            _settingsButton.onClick.AddListener(OnSettingsButtonClick);
        }
        private void OnDisable()
        {
            _restartButton.onClick.RemoveAllListeners();
            _settingsButton.onClick.RemoveAllListeners();
        }

        private void Start()
        {
            InitShowedPopUp();
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
        private void OnRestartButtonClick()
        {
            RestartButtonPressed?.Invoke();
        }
        private void OnSettingsButtonClick()
        {
            SettingsButtonPressed?.Invoke();
        }
        #endregion
    }
}
