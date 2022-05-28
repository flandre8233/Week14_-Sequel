using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BouncingCube2;
namespace BouncingCube2
{
public class ComboAlpha : SingletonMonoBehavior<ComboAlpha>
{
    [SerializeField] CanvasGroup group;
    public float Alpha;
    // Start is called before the first frame update
    void Start()
    {
        Alpha = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Alpha -= Time.deltaTime * 0.3f;
        group.alpha = Alpha;
    }

    public void RecoverAlpha()
    {
        Alpha = 1;
    }
}
}