﻿using Budgeter.Domain.Model;

namespace Budgeter.BL.Core.Handlers.GenericResults
{
    public class AddEntityResult<T>
        where T : IEntity
    {
        public long EntityId { get; }
        public T Entity { get; }
    }
}