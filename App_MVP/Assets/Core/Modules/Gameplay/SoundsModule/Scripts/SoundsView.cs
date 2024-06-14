using Core.Abstractions.MVP;
using UnityEngine;

namespace Core.Modules.Gameplay.Sounds
{
    public class SoundsView : UIPopUp
    {
        #region Variables
        [SerializeField] private AudioSource _soundAudioSource;
        [SerializeField] private AudioSource _musicAudioSource;
        #endregion


        #region Unity lifecycle

        #endregion


        #region Public methods
        internal void ChangeMusicState(bool value)
        {
            if (value)
                _musicAudioSource.volume = 1;
            else 
                _musicAudioSource.volume = 0;
        }
        internal void ChangeSoundsState(bool value)
        {
            if (value)
                _soundAudioSource.volume = 1;
            else
                _soundAudioSource.volume = 0;
        }
        internal void PlayClickSound()
        {
            _soundAudioSource.Play();
        }
        #endregion


        #region Private methods

        #endregion
    }
}
