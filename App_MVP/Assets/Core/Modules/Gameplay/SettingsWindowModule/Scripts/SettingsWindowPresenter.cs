using Core.Abstractions.MVP;
using Core.Modules.Gameplay.MainWindow;
using UnityEngine;

namespace Core.Modules.Gameplay.SettingsWindow
{
    public class SettingsWindowPresenter : PresenterBase<SettingsWindowModel, SettingsWindowView>
    {
        protected override void Present()
        {
            Model.ShowRequested += Model_ShowRequested;
            Model.HideRequested += Model_HideRequested;

            View.CloseButtonPressed += View_CloseButtonPressed;
            View.SoundTogglePressed += View_SoundTogglePressed;
            View.MusicTogglePressed += View_MusicTogglePressed;
        }
        public override void Dispose()
        {
            Model.ShowRequested -= Model_ShowRequested;
            Model.HideRequested -= Model_HideRequested;

            View.CloseButtonPressed -= View_CloseButtonPressed;
            View.SoundTogglePressed -= View_SoundTogglePressed;
            View.MusicTogglePressed -= View_MusicTogglePressed;
        }

        private void Model_ShowRequested()
        {
            View.ShowView();
        }
        private void Model_HideRequested()
        {
            View.HideView();
        }

        private void View_CloseButtonPressed()
        {
            Model.HideSettings();
        }
        private void View_SoundTogglePressed(bool value)
        {

        }
        private void View_MusicTogglePressed(bool value)
        {

        }
    }
}
