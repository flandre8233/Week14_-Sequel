using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BouncingCube2;
namespace BouncingCube2
{
public class ComboResultText : LerpValText
{

    protected override float DelayTime()
    {
        return 3f;
    }
    protected override string GetTitle()
    {
        return "MaxCombo";
    }

    protected override int GetTargetVal()
    {
        return ScoreCounter.instance.GetMaxCombo();
    }
}
}