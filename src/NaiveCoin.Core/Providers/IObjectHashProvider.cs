﻿namespace NaiveCoin.Core.Providers
{
    public interface IObjectHashProvider
    {
        byte[] ComputeHashBytes(string any);
        byte[] ComputeHashBytes(object instance);
        string ComputeHash(object instance);
        string ComputeHash(string any);
    }
}