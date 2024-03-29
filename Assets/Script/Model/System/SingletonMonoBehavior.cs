﻿using UnityEngine;
using System.Collections;
using BouncingCube2;
namespace BouncingCube2
{
public abstract class SingletonMonoBehavior<T> : MonoBehaviour {

    private static T _instance;

    public virtual void Awake() {
        if (_instance == null || _instance.Equals(default(T)))
            _instance = (T)((System.Object)this);
    }

    public static T instance {
        get { return _instance; }
    }

    public static void ClearInstance(){
       _instance = default(T);
    }

}

}