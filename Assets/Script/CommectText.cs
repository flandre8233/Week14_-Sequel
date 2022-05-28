using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BouncingCube2;
namespace BouncingCube2
{
public class CommectText : CommonUIText
{
    public int ComboNumber;
    public int Score;

    protected override void Start()
    {
        base.Start();
        UpdateText();
    }
    public override void UpdateText()
    {
        text.text = "+ " + Score + " !" + '\n' + GetText();
        text.color = ComboColor.instance.GetCurrentColor();
        float Scale = 1 + (0.15f * ComboNumber);
        transform.localScale = new Vector3(Scale, Scale, Scale);
    }

    string GetText()
    {
        switch (ComboNumber)
        {
            default:
                return "Fine";
            case 3:
                return "Good";
            case 4:
                return "Nice!";
            case 5:
                return "Great!!";
            case 6:
                return "Prefect!!!";
        }
    }
}
}