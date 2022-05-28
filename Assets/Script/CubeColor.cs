using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BouncingCube2;
namespace BouncingCube2
{
public class CubeColor : MonoBehaviour
{
    [SerializeField] Color StartColor;
    [SerializeField] Color WantedColor;

    Color CurrentColor;
    [SerializeField] float NeedTime;
    float CurrentTime;
    [SerializeField] MeshRenderer MeshRenderer;

    public void ResetColor()
    {
        CurrentTime = 0;
    }

    void Update()
    {
        CurrentTime += Time.deltaTime;
        CurrentTime = Mathf.Clamp(CurrentTime, 0, NeedTime);
        CurrentColor = Color.Lerp(StartColor, WantedColor, CurrentTime / NeedTime);
        MeshRenderer.material.color = CurrentColor;
    }
}
}