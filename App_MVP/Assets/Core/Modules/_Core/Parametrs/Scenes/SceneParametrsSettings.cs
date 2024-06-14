using UnityEngine;

namespace Core.Modules.Core.Parametrs
{
    [CreateAssetMenu(fileName = "Scene Settings", menuName = "Core/Parametrs/SceneSettings")]
    public class SceneParametrsSettings : ScriptableObject
    {
        [SerializeField] private string _mainScene;
        [SerializeField] private string _startScene;

        public string MainScene
        {
            get { return _mainScene; }
            private set { }
        }

        public string StartScene
        {
            get { return _startScene; }
            private set { }
        }
    }
}
