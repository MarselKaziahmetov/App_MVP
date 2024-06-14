using Core.Abstractions.MVP;
using UnityEngine;

namespace Core.Modules.Gameplay.Sounds
{
    [CreateAssetMenu(fileName = "SoundsVolume Module Installer", menuName = "Core/Moduls Installers/SoundsVolume Module Installer", order = 1)]
    public class SoundsInstaller : MvpInstallerBase<SoundsModel, SoundsPresenter, SoundsView>
    {
    }
}
