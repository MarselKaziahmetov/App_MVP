using UnityEngine;
using Zenject;

namespace Core.Modules.Gameplay.StartModule
{
    [CreateAssetMenu(menuName = "Core/Gameplay Installers/Start Window Installer", order = 1)]
    public class StartWindowInstaller : ScriptableObjectInstaller
    {
        public override void InstallBindings()
        {
            BindStartWindowViewPresenter();
        }

        protected virtual void BindStartWindowViewPresenter()
        {
            Container.BindInterfacesAndSelfTo<StartWindowModuleView>().FromComponentInHierarchy().AsSingle();
            Container.BindInterfacesAndSelfTo<StartWindowModulePresenter>().AsSingle().NonLazy();
        }
    }
}
