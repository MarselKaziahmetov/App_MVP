using Core.Modules.Gameplay.SampleModule;
using UnityEngine;
using Zenject;

namespace Core.Installers
{
    [CreateAssetMenu(menuName = "Core/Main Installers/Core ViewPresenterInstaller", order = 1)]
    public class Core_ViewPresenterInstaller : ScriptableObjectInstaller
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
        protected virtual void BindMainWindowViewPresenter()
        {
            Container.BindInterfacesAndSelfTo<StartWindowModuleView>().FromComponentInHierarchy().AsSingle();
            Container.BindInterfacesAndSelfTo<StartWindowModulePresenter>().AsSingle().NonLazy();
        }
    }
}
