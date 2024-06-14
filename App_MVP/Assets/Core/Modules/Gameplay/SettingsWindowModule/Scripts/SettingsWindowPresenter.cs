using Core.Abstractions.MVP;

namespace Core.Modules.Gameplay.SettingsWindow
{
    public class SettingsWindowPresenter : PresenterBase<SettingsWindowModel, SettingsWindowView>
    {
        protected override void Present()
        {
            Model.ShowRequested += Model_ShowRequested;
            Model.HideRequested += Model_HideRequested;
            Model.SoundInitRequested += Model_InitSoundState;
            Model.MusicInitRequested += Model_InitMusicState;

            View.CloseButtonPressed += View_CloseButtonPressed;
            View.SoundTogglePressed += View_SoundTogglePressed;
            View.MusicTogglePressed += View_MusicTogglePressed;

            Model.InitMusicSettings();
            Model.InitSoundSettings();
        }
        public override void Dispose()
        {
            Model.ShowRequested -= Model_ShowRequested;
            Model.HideRequested -= Model_HideRequested;
            Model.SoundInitRequested -= Model_InitSoundState;
            Model.MusicInitRequested -= Model_InitMusicState;

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
        private void Model_InitMusicState(bool value)
        {
            View.InitMusicToggle(value);
        }
        private void Model_InitSoundState(bool value)
        {
            View.InitSoundToggle(value);
        }

        private void View_CloseButtonPressed()
        {
            Model.HideSettings();
        }
        private void View_SoundTogglePressed(bool value)
        {
            Model.SaveSoundVolumeToggle(value);
        }
        private void View_MusicTogglePressed(bool value)
        {
            Model.SaveMusicVolumeToggle(value);
        }
    }
}
