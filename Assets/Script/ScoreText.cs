using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BouncingCube2;
namespace BouncingCube2
{
public class ScoreText : CommonUIText
{
    [SerializeField]
    ScoreScale ScoreScale;

    [SerializeField]
    float CurrentScore = 0;
    [SerializeField]
    float WantedScore = 0;
    public override void UpdateText()
    {
        WantedScore = ScoreCounter.instance.Score;
        ScoreScale.AddScale();
    }

    private void Update()
    {
        CurrentScore = Mathf.Lerp(CurrentScore, WantedScore, Time.deltaTime * 7);
        text.text = Mathf.RoundToInt(CurrentScore).ToString();
    }
}
}