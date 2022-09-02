using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BouncingCube2;
namespace BouncingCube2
{
public class PlanetRotate : MonoBehaviour
{
    public float PlanetRotateSpeed;
    private void Update()
    {
        transform.Rotate(new Vector3(0, 0, PlanetRotateSpeed * Time.deltaTime));
    }
}
}