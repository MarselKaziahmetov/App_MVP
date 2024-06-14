using Core.Modules.Core;
using Core.Modules.Core.Parametrs;
using Core.Modules.Gameplay.SampleModule;
using Core.Modules.Core.SceneSwitcher;
using Core.Modules.Core.TimeScaler;
using UnityEngine;
using Zenject;

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
            BindSampleModel();

            BindUIParametrs();
            BindSceneParametrs();

            BindTimeScaler();
        }

        protected virtual void BindSampleModel()
        {
            Container.BindInterfacesAndSelfTo<StartWindowModuleModel>().AsSingle();
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
