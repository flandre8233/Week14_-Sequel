using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BouncingCube2;
namespace BouncingCube2
{
public class FloatingText : CommonUIText
{
    [SerializeField] ComboScale scale;
    protected override void Start()
    {
        base.Start();
        text.text = "";
    }
    public override void UpdateText()
    {
        scale.AddScale();
        text.text = ScoreCounter.instance.Floating.ToString() + "Hit!";
    }
}
}