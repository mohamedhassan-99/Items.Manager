﻿namespace Items.Manager.Domain.Common.Contract;

public interface IEntity
{
    IReadOnlyList<IDomainEvent> GetDomainEvents();

    void ClearDomainEvents();
}