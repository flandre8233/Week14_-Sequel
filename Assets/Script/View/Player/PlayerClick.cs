using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BouncingCube2;
namespace BouncingCube2
{
public class PlayerClick : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (BackgroundClick.IsClicked)
        {
            return;
        }
        PlayerControll.instance.OnPlayerClickBouningCube();
    }
}
}