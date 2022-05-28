using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BouncingCube2;
namespace BouncingCube2
{
public class ReflectSoundSpawner : MonoBehaviour
{
    public static void Spawn()
    {
        GameObject SpawnObject = ResourcesSpawner.Spawn("AttackSound", 2f);
        AudioSource AS = SpawnObject.GetComponent<AudioSource>();
        AS.pitch = (1 + (0.25f * ScoreCounter.instance.GetCombo()));
    }


}
}