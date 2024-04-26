﻿using TA.Domain.IEntity;

namespace TA.Domain.Model
{
    public class BaseViewModel<TId> : IBaseEntity<TId>
    {
        public TId? Id { get; set; }
    }
}
