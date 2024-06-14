using Core.Abstractions.Sounds;
using System;

namespace Core.Modules.Gameplay.Sounds
{
    public class SoundsModel : ISoundsController
    {
        public event Action PlayClickSoundRequested;
        public event Action<bool> ChangeSoundsStateRequested;
        public event Action<bool> ChangeMusicStateRequested;


        public void PlayClickSound()
        {
            PlayClickSoundRequested?.Invoke();
        }

        public void ChangeMusicState(bool value)
        {
            ChangeMusicStateRequested?.Invoke(value);
        }

        public void ChangeSoundsState(bool value)
        {
            ChangeSoundsStateRequested?.Invoke(value);
        }
    }
}
