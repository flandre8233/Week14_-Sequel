using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using BouncingCube2;
namespace BouncingCube2
{
public class ComboText : CommonUIText
{
    [SerializeField] ComboScale comboScale;
    [SerializeField] ComboAlpha comboAlpha;
    public override void UpdateText()
    {
        text.text = ScoreCounter.instance.GetCombo() + "x";
        text.color = ComboColor.instance.GetCurrentColor();
        comboScale.AddScale();
        comboAlpha.RecoverAlpha();
    }


}
}