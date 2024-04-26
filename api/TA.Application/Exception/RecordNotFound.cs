﻿using TA.Domain.Constant;

namespace TA.Application.Exception
{
    public class RecordNotFound : DomainException
    {
        public RecordNotFound(string msg = "The record you are trying to update is not found") : base(msg)
        {

        }

        public override int ToHttpStatusCode()
        {
            return AppStatusCode.BadRequestStatusCode;
        }
    }
}