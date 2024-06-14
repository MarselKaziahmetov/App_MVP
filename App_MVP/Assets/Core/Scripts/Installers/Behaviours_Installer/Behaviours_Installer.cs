using Core.Behaviours;
using UnityEngine;
using Zenject;

namespace Core.Installers
{
	[CreateAssetMenu(menuName = "Core/Main Installers/Behaviours Installer")]
	public class Behaviours_Installer : ScriptableObjectInstaller
	{
		public override void InstallBindings()
		{
			BindDefaultBehaviours();

			BindExtendedBahaviours();

			Container.BindInterfacesAndSelfTo<BehaviourEnabler>().AsSingle().NonLazy();
		}


		public virtual void BindDefaultBehaviours()
		{
            Container.BindInterfacesTo<ViewInitializerBehaviour>().AsSingle();
            Container.BindInterfacesTo<MainSceneLoaderBehaviour>().AsSingle();
            Container.BindInterfacesTo<SettingsShowHideBehaviour>().AsSingle();
        }

		public virtual void BindExtendedBahaviours()
		{
		}
	}
}
