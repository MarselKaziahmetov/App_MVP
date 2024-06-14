using Core.Abstractions.MVP;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System;

namespace Core.Modules.Gameplay.SampleModule
{   
    public class StartWindowModuleView : UIPopUp
    {
        #region Variables
        [SerializeField] private Button _nextButton;
        [SerializeField] private float _delay;

        public event Action NextButtonPressed;
        public event Action ShowViewRequested;
        #endregion

        #region Unity lifecycle
        private void OnEnable()
        {
            _nextButton.onClick.AddListener(OnNextButtonClick);
        }
        private void OnDisable()
        {
            _nextButton.onClick.RemoveAllListeners();
        }

        private void Start()
        {
            InitHidedPopUp();
            StartCoroutine(ShowWithDelay());
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
        private void OnNextButtonClick()
        {
            NextButtonPressed?.Invoke();
        }
        private void RequestShowView()
        {
            ShowViewRequested?.Invoke();
        }
        private IEnumerator ShowWithDelay()
        {
            yield return new WaitForSeconds(_delay);
            RequestShowView();
        }
        #endregion
    }
}
