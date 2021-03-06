﻿using System.Net;

namespace LindDotNetCore.Exceptions
{
    /// <summary>
    /// 未授权的异常
    /// </summary>
    public class NoAuthorizationException : HttpStatusExcetion
    {
        public NoAuthorizationException(string message) : base(message)
        {
        }

        public override HttpStatusCode HttpStatusCode => HttpStatusCode.Unauthorized;
    }
}