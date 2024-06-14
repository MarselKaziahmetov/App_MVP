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
        [SerializeField] private Button _hideButton;
        [SerializeField] private float _delay;

        public event Action HideViewRequested;
        public event Action ShowViewRequested;
        #endregion

        #region Unity lifecycle
        private void OnEnable()
        {
            _hideButton.onClick.AddListener(OnHideButtonClick);
        }
        private void OnDisable()
        {
            _hideButton.onClick.RemoveAllListeners();
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
        private void OnHideButtonClick()
        {
            HideViewRequested?.Invoke();
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
