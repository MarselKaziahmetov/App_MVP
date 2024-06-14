using Core.Abstractions.MVP;

namespace Core.Modules.Gameplay.Sounds
{
    public class SoundsPresenter : PresenterBase<SoundsModel, SoundsView>
    {
        protected override void Present()
        {
            Model.PlayClickSoundRequested += Model_PlayClickSound;
            Model.ChangeMusicStateRequested += Model_ChangeMusicState;
            Model.ChangeSoundsStateRequested += Model_ChangeSoundsState;
        }
        public override void Dispose()
        {
            Model.PlayClickSoundRequested -= Model_PlayClickSound;

            Model.ChangeMusicStateRequested -= Model_ChangeMusicState;
            Model.ChangeSoundsStateRequested -= Model_ChangeSoundsState;
        }

        private void Model_PlayClickSound()
        {
            View.PlayClickSound();
        }
        private void Model_ChangeMusicState(bool value)
        {
            View.ChangeMusicState(value);
        }
        private void Model_ChangeSoundsState(bool value)
        {
            View.ChangeSoundsState(value);
        }
    }
}
