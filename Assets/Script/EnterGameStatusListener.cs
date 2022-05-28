using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BouncingCube2;
namespace BouncingCube2
{
public class EnterGameStatusListener : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
         if (Input.GetMouseButtonDown(0))
        {
            StatusControll.ToNewStatus(new GameStatus());
        }
    }
}
}