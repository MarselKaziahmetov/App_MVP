using Core.Abstractions.MainWindow;
using Core.Abstractions.SettingsWindow;

namespace Core.Behaviours
{
    public class SettingsWindowBehaviour : IBehaviour
    {
        private readonly IMainWindowModule _mainWindow;
        private readonly ISettingsWindowModule _settingsWindow;

        public SettingsWindowBehaviour(IMainWindowModule mainWindow, ISettingsWindowModule settingsWindow)
        {
            _mainWindow = mainWindow;
            _settingsWindow = settingsWindow;
        }

        public void Enable()
        {
            _mainWindow.SettingsWindowRequested += ShowSettings;
        }

        private void ShowSettings()
        {
            _settingsWindow.ShowSettings();
        }
    }
}
