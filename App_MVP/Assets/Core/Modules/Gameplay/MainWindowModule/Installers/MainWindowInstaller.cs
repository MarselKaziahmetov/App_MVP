using UnityEngine;
using Zenject;

namespace Core.Modules.Gameplay.MainWindow
{
    [CreateAssetMenu(menuName = "Core/Gameplay Installers/Main Window Installer", order = 1)]
    public class MainWindowInstaller : ScriptableObjectInstaller
    {
        public override void InstallBindings()
        {
            BindMainWindowViewPresenter();
        }

        protected virtual void BindMainWindowViewPresenter()
        {
            Container.BindInterfacesAndSelfTo<MainWindowView>().FromComponentInHierarchy().AsSingle();
            Container.BindInterfacesAndSelfTo<MainWindowPresenter>().AsSingle().NonLazy();
        }
    }
}
