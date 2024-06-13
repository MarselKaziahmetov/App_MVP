using UnityEngine;
using Zenject;

namespace Core.Abstractions.MVP
{
	public class MvpInstallerBase<TModel, TPresenter, TView> : ScriptableObjectInstaller
		where TView : MonoBehaviour
	{
		[SerializeField] private TView _viewPrefab;

		public override void InstallBindings()
		{
			Container.BindInterfacesAndSelfTo<TModel>().AsSingle();
			Container.BindInterfacesAndSelfTo<TView>().FromComponentInNewPrefab(_viewPrefab).AsSingle();
			Container.BindInterfacesAndSelfTo<TPresenter>().AsSingle().NonLazy();
		}
	}
}
