using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BouncingCube2;
namespace BouncingCube2
{
public class PlayerClickScoreBall : MonoBehaviour
{
    [SerializeField]
    ScoreBall Parent;

    private void OnMouseDown()
    {
        if (BackgroundClick.IsClicked)
        {
            return;
        }
        Destroy(Parent.gameObject);
        PlayerControll.instance.OnPlayerClickScoreBall(transform);
    }
}
}