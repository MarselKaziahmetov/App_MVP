using Core.Abstractions.SettingsWindow;
using Core.Abstractions.Sounds;

namespace Core.Behaviours
{
    public class VolumeTogglesBehaviour : IBehaviour
    {
        private readonly ISettingsWindowModule _settingsWindow;
        private readonly ISoundsController _soundsController;

        public VolumeTogglesBehaviour(ISettingsWindowModule settingsWindow, ISoundsController soundsController)
        {
            _settingsWindow = settingsWindow;
            _soundsController = soundsController;
        }

        public void Enable()
        {
            _settingsWindow.MusicStateChanged += ChangeMusicState;
            _settingsWindow.SoundStateChanged += ChangeSoundState;
        }

        private void ChangeMusicState(bool value)
        {
            _soundsController.ChangeMusicState(value);
        }
        private void ChangeSoundState(bool value)
        {
            _soundsController.ChangeSoundsState(value);
        }
    }
}
