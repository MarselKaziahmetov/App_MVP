using Core.Abstractions.MVP;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System;

namespace Core.Modules.Gameplay.SampleModule
{   
    public class SampleModuleView : UIPopUp
    {
        #region Variables
        [SerializeField] private CanvasGroup _testWindow;
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
        #endregion


        #region Public methods
        internal void HideView()
        {
            Hide_ElementScaling_ViewFading(_testWindow.gameObject);
            StartCoroutine(ShowWithDelay());
        }
        internal void ShowView()
        {
            Show_ElementScaling_ViewFading(_testWindow.gameObject);
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
