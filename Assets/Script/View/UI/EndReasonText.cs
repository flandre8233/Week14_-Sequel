using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BouncingCube2;
namespace BouncingCube2
{
public class EndReasonText : CommonUIText
{
    protected override void Start()
    {
        base.Start();
        UpdateText();
    }

    public override void UpdateText()
    {
        text.text = EndReason.instance.Get();
    }

}
}