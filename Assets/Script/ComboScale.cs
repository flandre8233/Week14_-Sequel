using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BouncingCube2;
namespace BouncingCube2
{
public class ComboScale : MonoBehaviour
{
    float Scale;
    // Start is called before the first frame update
    void Start()
    {
        Scale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Scale = Mathf.Lerp(Scale, 1, Time.deltaTime * 3);
        transform.localScale = new Vector3(Scale, Scale, Scale);
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.identity, Time.deltaTime * 9);
    }

    public void AddScale()
    {
        Scale += 0.35f;
        transform.eulerAngles += new Vector3(0, 0, 22.5f);
    }
}
}