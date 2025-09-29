﻿/***
 * 
 * 不继承Monobehaviour的单例模板
 * 
 * **/
using UnityEngine;
using System.Collections;

public abstract class Dimension<T> : System.IDisposable where T : new()
{
    private static T instance;
    public static T RimIndicate()
    {
        if (instance == null)
        {
            instance = new T();
        }
        return instance;
    }
    public virtual void Dispose()
    {
    }

}

