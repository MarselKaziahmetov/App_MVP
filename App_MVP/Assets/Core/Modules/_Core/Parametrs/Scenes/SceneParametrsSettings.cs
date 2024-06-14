using UnityEngine;

namespace Core.Modules.Core.Parametrs
{
#if UNITY_EDITOR
    using UnityEditor;
#endif

    [CreateAssetMenu(fileName = "Scene Settings", menuName = "Core/Parametrs/SceneSettings")]
    public class SceneParametrsSettings : ScriptableObject
    {
#if UNITY_EDITOR
        [SerializeField] private SceneAsset _mainScene;
        [SerializeField] private SceneAsset _startScene;
#endif

        public string MainScene
        {
            get
            {
#if UNITY_EDITOR
                return _mainScene != null ? _mainScene.name : string.Empty;
#else
                return string.Empty;
#endif
            }
            private set { }
        }

        public string StartScene
        {
            get
            {
#if UNITY_EDITOR
                return _startScene != null ? _startScene.name : string.Empty;
#else
                return string.Empty;
#endif
            }
            private set { }
        }
    }
}
