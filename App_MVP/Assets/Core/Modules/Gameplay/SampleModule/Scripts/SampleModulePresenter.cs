using Core.Abstractions.MVP;

namespace Core.Modules.Gameplay.SampleModule
{
    public class SampleModulePresenter : PresenterBase<SampleModuleModel, SampleModuleView>
    {
        protected override void Present()
        {
            Model.ShowRequested += Model_ShowRequested;
            Model.HideRequested += Model_HideRequested;

            View.HideViewRequested += View_HideRequested;
            View.ShowViewRequested += View_ShowRequested;
        }
        public override void Dispose()
        {
            Model.ShowRequested -= Model_ShowRequested;
            Model.HideRequested -= Model_HideRequested;

            View.HideViewRequested -= View_HideRequested;
            View.ShowViewRequested -= View_ShowRequested;
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
        private void View_HideRequested()
        {
            Model.HideView();
        }
    }
}
