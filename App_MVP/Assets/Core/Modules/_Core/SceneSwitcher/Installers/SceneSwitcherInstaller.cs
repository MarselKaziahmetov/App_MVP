using Core.Abstractions.MVP;
using Core.Modules.Core.SceneSwitcher;
using UnityEngine;

namespace Core.Modules.Core
{
    [CreateAssetMenu(fileName = "SceneSwitcherModule Installer", menuName = "Core/Moduls Installers/SceneSwitcherModule Installer", order = 1)]
    public class SceneSwitcherInstaller : MvpInstallerBase<SceneSwitcherModel, SceneSwitcherPresenter, SceneSwitcherView>
    {
    }
}
