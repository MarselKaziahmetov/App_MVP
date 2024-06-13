using Core.Modules.Gameplay.SampleModule;
using Core.Modules.Core.SceneSwitcher;
using UnityEngine;
using Zenject;

namespace Core.Installers
{
    [CreateAssetMenu(menuName = "Core/Main Installers/Core ViewPresenterInstaller", order = 1)]
    public class Core_ViewPresenterInstaller : ScriptableObjectInstaller
    {
        public override void InstallBindings()
        {
            BindSampleViewPresenter();
        }

        protected virtual void BindSampleViewPresenter()
        {
            Container.BindInterfacesAndSelfTo<SampleModuleView>().FromComponentInHierarchy().AsSingle();
            Container.BindInterfacesAndSelfTo<SampleModulePresenter>().AsSingle().NonLazy();
        }
    }
}
