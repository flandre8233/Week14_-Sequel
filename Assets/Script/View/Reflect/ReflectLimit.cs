using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BouncingCube2;
namespace BouncingCube2
{
public class ReflectLimit : SingletonMonoBehavior<ReflectLimit>
{
    [SerializeField] int MaxReflect;
    [SerializeField] int ReflectTime = 0;

    public void OnPlayerReflect(float ReflectDistance)
    {
        ReflectTime++;
        if (IsOverLimit())
        {
            print("IsOverLimit");
            ResourcesSpawner.Spawn("Explosion", transform.position, 3f);
            PlayerControll.instance.OnPlayerLose();
        }
        print("ReflectDistance : " + ReflectDistance);
        ReflectSoundSpawner.Spawn();
        PlayerScale.instance.OnPlayerReflecting();
        ScoreCounter.instance.OnPlayerGetScore((int)ReflectDistance, transform.position);
    }

    bool IsOverLimit()
    {
        return ReflectTime > MaxReflect;
    }
    public void OnPlayerLand(GameObject Cube)
    {
        ReflectTime = 0;
    }

    public int GetReflectTime()
    {
        return ReflectTime;
    }

 
}
}