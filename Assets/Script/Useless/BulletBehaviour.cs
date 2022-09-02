using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BouncingCube2;
namespace BouncingCube2
{
public class BulletBehaviour : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        print("hit " + other.name + "!");
        Destroy(gameObject);
    }
}
}