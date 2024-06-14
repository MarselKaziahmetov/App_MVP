using Core.Modules.Gameplay.SettingsWindow;
using UnityEngine;
using Zenject;

namespace Core.Modules.SettingsWindow
{

    [CreateAssetMenu(menuName = "Core/Gameplay Installers/Settings Window Installer", order = 1)]
    public class SettingsWindowInstaller : ScriptableObjectInstaller
    {
        public override void InstallBindings()
        {
            BindMainWindowViewPresenter();
        }

        protected virtual void BindMainWindowViewPresenter()
        {
            Container.BindInterfacesAndSelfTo<SettingsWindowView>().FromComponentInHierarchy().AsSingle();
            Container.BindInterfacesAndSelfTo<SettingsWindowPresenter>().AsSingle().NonLazy();
        }
    }
}
