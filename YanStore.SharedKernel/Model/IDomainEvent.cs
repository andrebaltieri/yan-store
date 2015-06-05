using System;

namespace YanStore.SharedKernel.Model
{
    public interface IDomainEvent
    {
        DateTime DateOccurred { get; }
    }
}
