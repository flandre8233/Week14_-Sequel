using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using BouncingCube2;
namespace BouncingCube2
{
public class ComboPass : MonoBehaviour
{
    [SerializeField] CommonUIText ComboUI;
    [SerializeField] CommonUIText HitUI;
    [SerializeField] Text MyText;

    [SerializeField] RectTransform RectTransform;
    [SerializeField] CanvasGroup MyGroup;

    [SerializeField] Transform LeftTrans;

    private void OnEnable()
    {
        RectTransform.anchoredPosition = new Vector2(0, 0);
        MyGroup.alpha = 1;
        MyText.text = ComboUI.GetString();
        MyText.color = ComboUI.GetText().color;
        ScoreCounter.instance.ResetCombo();
        ComboAlpha.instance.Alpha = 0;
    }

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, LeftTrans.position, Time.deltaTime * 3);
        MyGroup.alpha = Mathf.Lerp(MyGroup.alpha, 0, Time.deltaTime * 3);

        if (MyGroup.alpha <= 0.1f)
        {
            transform.position = LeftTrans.position;
            MyGroup.alpha = 0;
            HitUI.UpdateText();
            enabled = false;
        }
    }
}
}