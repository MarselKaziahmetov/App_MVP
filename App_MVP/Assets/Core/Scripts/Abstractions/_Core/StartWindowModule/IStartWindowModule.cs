using System;

namespace Core.Abstractions.Sample
{
    public interface IStartWindowModule
    {
        bool IsHided { get; }

        event Action HideRequested;
        event Action ShowRequested;
        event Action MainSceneLoadRequested;
    }
}
