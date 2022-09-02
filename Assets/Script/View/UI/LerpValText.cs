using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BouncingCube2;
namespace BouncingCube2
{
public abstract class LerpValText : CommonUIText
{
    [SerializeField] float CurrentVal;
    [SerializeField] float WantedVal;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        Invoke("UpdateDelay", DelayTime());
        WantedVal = GetTargetVal();
        UpdateText();
    }


    protected abstract float DelayTime();
    protected abstract int GetTargetVal();
    protected abstract string GetTitle();

    void UpdateDelay()
    {
        globalUpdateManager.instance.registerUpdateDg(UpdateScore);
    }

    public override void UpdateText()
    {
        text.text = GetTitle() + " : " + Mathf.RoundToInt(CurrentVal);
    }

    // Update is called once per frame
    void UpdateScore()
    {
        CurrentVal = Mathf.Lerp(CurrentVal, WantedVal, Time.deltaTime * 3);

        if (CurrentVal / WantedVal >= 0.9f)
        {
            CurrentVal = WantedVal;
        }
        UpdateText();
    }

    private void OnDestroy()
    {
        globalUpdateManager.instance.UnregisterUpdateDg(UpdateScore);
    }
}
}