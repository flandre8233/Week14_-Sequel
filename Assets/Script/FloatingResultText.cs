using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BouncingCube2;
namespace BouncingCube2
{
public class FloatingResultText : LerpValText
{

    protected override float DelayTime()
    {
        return 4f;
    }
    protected override string GetTitle()
    {
        return "Hit";
    }

    protected override int GetTargetVal()
    {
        return ScoreCounter.instance.Floating;
    }
}
}