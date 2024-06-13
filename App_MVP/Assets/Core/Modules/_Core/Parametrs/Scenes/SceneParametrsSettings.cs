using UnityEditor;
using UnityEngine;

namespace Core.Modules.Core.Parametrs
{
    [CreateAssetMenu(fileName = "Scene Settings", menuName = "Core/Parametrs/SceneSettings")]
    public class SceneParametrsSettings : ScriptableObject
    {
        [SerializeField] private SceneAsset _mainScene;
        [SerializeField] private SceneAsset _switchScene;

        public string MainScene
        {
            get { return _mainScene.name; }
            private set { }
        }

        public string SwitchScene
        {
            get { return _switchScene.name; }
            private set { }
        }
    }
}
