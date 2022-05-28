using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BouncingCube2;
namespace BouncingCube2
{
public class InvisibleListener : MonoBehaviour
{
    private void Update()
    {
        Vector3 PlayerViewPortPoint = Camera.main.WorldToViewportPoint(PlayerControll.instance.GetPlayerObject().transform.position);
        if (PlayerViewPortPoint.y > 1.5f)
        {
            EndReason.instance.Set("Too High!!");
            PlayerControll.instance.OnPlayerLose();
        }

        if (PlayerViewPortPoint.y < -0.2f)
        {
            EndReason.instance.Set("Too Low!!");
            PlayerControll.instance.OnPlayerLose();
        }

    }

}
}