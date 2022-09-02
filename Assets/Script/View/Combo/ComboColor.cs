using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BouncingCube2;
namespace BouncingCube2
{
public class ComboColor : SingletonMonoBehavior<ComboColor>
{
    public Color GetCurrentColor()
    {
        return GetColor(ScoreCounter.instance.GetCombo());
    }

    public Color GetColor(int ColorIndex)
    {
        float CurLerpT = (float)ColorIndex / (float)8;
        Color NewColor = Color.Lerp(Color.cyan, Color.red, CurLerpT);
        return NewColor;
    }
}
}