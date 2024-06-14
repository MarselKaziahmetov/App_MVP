using Core.Abstractions.MainWindow;
using Core.Abstractions.Sample;
using Core.Abstractions.SettingsWindow;
using Core.Abstractions.Sounds;

namespace Core.Behaviours
{
    public class ClickSoundBehaviour : IBehaviour
    {
        private readonly IStartWindowModule _startWindow;
        private readonly IMainWindowModule _mainWindow;
        private readonly ISettingsWindowModule _settingsWindow;
        private readonly ISoundsController _soundsController;

        public ClickSoundBehaviour(IStartWindowModule startWindow, IMainWindowModule mainWindow, 
            ISettingsWindowModule settingsWindow, ISoundsController soundsController)
        {
            _startWindow = startWindow;
            _mainWindow = mainWindow;
            _settingsWindow = settingsWindow;
            _soundsController = soundsController;
        }

        public void Enable()
        {
            _startWindow.MainSceneLoadRequested += PlayClickSound;
            _settingsWindow.CloseButtonPressed += PlayClickSound;
            _mainWindow.MainSceneLoadRequested += PlayClickSound;
            _mainWindow.SettingsWindowRequested += PlayClickSound;
        }

        private void PlayClickSound()
        {
            _soundsController.PlayClickSound();
        }

    }
}
