using Core.Abstractions.MVP;

namespace Core.Modules.Gameplay.MainWindow
{
    public class MainWindowPresenter : PresenterBase<MainWindowModel, MainWindowView>
    {
        protected override void Present()
        {
            Model.ShowRequested += Model_ShowRequested;
            Model.HideRequested += Model_HideRequested;

            View.RestartButtonPressed += View_RestartButtonPressed;
            View.SettingsButtonPressed += View_ShowRequested;
        }
        public override void Dispose()
        {
            Model.ShowRequested -= Model_ShowRequested;
            Model.HideRequested -= Model_HideRequested;

            View.RestartButtonPressed -= View_RestartButtonPressed;
            View.SettingsButtonPressed -= View_ShowRequested;
        }

        private void Model_ShowRequested()
        {
            View.ShowView();
        }
        private void Model_HideRequested()
        {
            View.HideView();
        }

        private void View_ShowRequested()
        {
            Model.ShowView();
        }
        private void View_RestartButtonPressed()
        {
            Model.LoadMainScene();
        }


    }
}
