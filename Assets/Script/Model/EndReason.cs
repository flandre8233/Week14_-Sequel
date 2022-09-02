using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BouncingCube2;
namespace BouncingCube2
{
public class EndReason : SingletonMonoBehavior<EndReason>
{
    string Reason = "";
    public void Set(string _Reason)
    {
        if (Reason != "")
        {
            return;
        }
        Reason = _Reason;
    }

    public string Get()
    {
        return Reason;
    }

}
}