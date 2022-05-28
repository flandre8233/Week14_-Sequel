using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using BouncingCube2;
namespace BouncingCube2
{
public class ScoreResultText : LerpValText
{
    protected override float DelayTime()
    {
        return 2f;
    }
    protected override string GetTitle()
    {
        return "Score";
    }

    protected override int GetTargetVal()
    {
        return ScoreCounter.instance.Score;
    }
}
}