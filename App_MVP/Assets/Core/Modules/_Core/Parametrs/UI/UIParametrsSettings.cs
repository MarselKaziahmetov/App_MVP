using UnityEngine;

namespace Core.Modules.Core.Parametrs
{
    [CreateAssetMenu(fileName = "UI Parametrs Settings", menuName = "Core/Parametrs/UIParametrsSettings")]
    public class UIParametrsSettings : ScriptableObject
    {
        [SerializeField] private float _fadeDuration;
        [SerializeField] private float _scalingDuration;

        public float FadeDuration => _fadeDuration;
        public float ScalingDuration => _scalingDuration;
    }
}
