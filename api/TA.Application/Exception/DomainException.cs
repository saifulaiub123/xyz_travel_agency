﻿using TA.Domain.Constant;

namespace TA.Application.Exception
{
    public class DomainException : System.Exception
    {
        public DomainException(string msg) : base(msg)
        {

        }

        public virtual int ToHttpStatusCode()
        {
            return AppStatusCode.BadRequestStatusCode;
        }
    }
}
