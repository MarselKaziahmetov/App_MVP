using Core.Abstractions.Parametrs;

namespace Core.Modules.Core.Parametrs
{
    public class UIParametrs: IUIParametrs
    {
        public float FadeDuration { get; }
        public float ScalingDuration { get; }

        public UIParametrs(UIParametrsSettings UIParametrsSettings)
        {
            FadeDuration = UIParametrsSettings.FadeDuration;
            ScalingDuration = UIParametrsSettings.ScalingDuration;
        }
    }
}
