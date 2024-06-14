using System;

namespace Core.Abstractions.Sounds
{
    public interface ISoundsController
    {
        event Action PlayClickSoundRequested;

        event Action<bool> ChangeMusicStateRequested;
        event Action<bool> ChangeSoundsStateRequested;

        void ChangeMusicState(bool value);
        void ChangeSoundsState(bool value);

        void PlayClickSound();
    }
}
