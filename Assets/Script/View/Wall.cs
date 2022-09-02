using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BouncingCube2;
namespace BouncingCube2
{
public class Wall : MonoBehaviour
{
    [SerializeField] Vector2 ViewPort;

    private void Update()
    {

        Vector3 worldpoint = Camera.main.ViewportToWorldPoint(ViewPort);
        transform.position = new Vector3(worldpoint.x, worldpoint.y, 0);
    }

}
}