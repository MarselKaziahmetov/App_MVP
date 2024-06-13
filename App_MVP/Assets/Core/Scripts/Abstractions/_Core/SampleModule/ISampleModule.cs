using System;

namespace Core.Abstractions.Sample
{
    public interface ISampleModule
    {
        bool IsHided { get; }

        event Action HideRequested;
        event Action ShowRequested;
    }
}
