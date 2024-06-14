using UnityEngine.SceneManagement;

namespace Core.Abstractions.Parametrs
{
    public interface ISceneParametrs
    {
        string MainScene { get; }
        string StartScene { get; }
    }
}
