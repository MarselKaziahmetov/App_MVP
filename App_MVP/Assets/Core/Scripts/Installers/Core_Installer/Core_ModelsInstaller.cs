using Core.Modules.Core;
using Core.Modules.Core.Parametrs;
using Core.Modules.Gameplay.StartModule;
using Core.Modules.Gameplay.MainWindow;
using Core.Modules.Core.TimeScaler;
using UnityEngine;
using Zenject;
using Core.Modules.Gameplay.SettingsWindow;

namespace Core.Installers
{
	[CreateAssetMenu(menuName = "Core/Main Installers/Core ModelsInstaller", order = 1)]
	public class Core_ModelsInstaller : ScriptableObjectInstaller
    {
        [Header("Gloabal Settings")]
        [SerializeField] private UIParametrsSettings _UIParametrsSettings;
        [SerializeField] private SceneParametrsSettings _sceneParametrs;

        public override void InstallBindings()
		{
            BindStartWindowModel();
            BindMainWindowModel();
            BindSettingsWindowModel();

            BindUIParametrs();
            BindSceneParametrs();

            BindTimeScaler();
        }

        protected virtual void BindStartWindowModel()
        {
            Container.BindInterfacesAndSelfTo<StartWindowModuleModel>().AsSingle();
        }
        protected virtual void BindMainWindowModel()
        {
            Container.BindInterfacesAndSelfTo<MainWindowModel>().AsSingle();
        }
        protected virtual void BindSettingsWindowModel()
        {
            Container.BindInterfacesAndSelfTo<SettingsWindowModel>().AsSingle();
        }


        protected virtual void BindUIParametrs()
        {
            Container.BindInterfacesTo<UIParametrs>().AsSingle().WithArguments(_UIParametrsSettings);
        }
        protected virtual void BindSceneParametrs()
        {
            Container.BindInterfacesTo<SceneParametrs>().AsSingle().WithArguments(_sceneParametrs);
        }

        protected virtual void BindTimeScaler()
        {
            Container.BindInterfacesTo<TimeScalerService>().AsSingle();
        }
    }
}
