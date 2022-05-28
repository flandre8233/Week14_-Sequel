using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BouncingCube2;
namespace BouncingCube2
{
public class BackgroundClick : SingletonMonoBehavior<BackgroundClick>
{
    public static bool IsClicked;




    private void OnMouseDown()
    {
        if (BackgroundClick.IsClicked)
        {
            return;
        }
        EndReason.instance.Set("Wrong Click!!");
        BackgroundClick.IsClicked = true;
        Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 WorldPos = new Vector3(MousePos.x, MousePos.y, 1);
        ResourcesSpawner.Spawn("X", WorldPos);
    }

    private void OnDestroy()
    {
        BackgroundClick.IsClicked = false;
    }
}

}