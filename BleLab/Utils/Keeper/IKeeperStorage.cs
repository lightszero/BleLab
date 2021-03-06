﻿namespace BleLab.Utils.Keeper
{
    public interface IKeeperStorage
    {
        bool HasKey(string key);

        object GetValue(string key);

        void SetValue(string key, object value);
    }
}