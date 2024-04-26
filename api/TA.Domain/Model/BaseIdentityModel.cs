﻿using TA.Domain.IEntity;

namespace TA.Domain.Model
{
    public class BaseIdentityModel<TId> : IBaseEntity<TId>
    {
        //public BaseIdentityModel()
        //{
        //    DateCreated = DateTime.Now;
        //}
        public TId Id { get; set; }
        //[Column(TypeName = DbDataType.DateTime)]
        //public DateTime DateCreated { get; set; }
    }
}
