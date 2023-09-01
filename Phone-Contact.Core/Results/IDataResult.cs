﻿namespace Phone_Contact.Core.Results
{
    public interface IDataResult<out T> : IResult
    {
        T Data { get; }
    }
}
