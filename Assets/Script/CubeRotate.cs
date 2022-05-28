using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BouncingCube2;
namespace BouncingCube2
{
public class CubeRotate : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D RB2D;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
transform.Rotate(new Vector3(0,0,RB2D.velocity.x * -6.25f));
    }
}
}