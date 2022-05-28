using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BouncingCube2;
namespace BouncingCube2
{
public class CubeScoreCounter : SingletonMonoBehavior<CubeScoreCounter>
{
    int MaxScore = 10;

    public int GetDisantceScore()
    {
        float ViewPortY = 1 - Camera.main.WorldToViewportPoint(transform.position).y;
        return Mathf.RoundToInt(MaxScore * ViewPortY);
    }

   
}
}