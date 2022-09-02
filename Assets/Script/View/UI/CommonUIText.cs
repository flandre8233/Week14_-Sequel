using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using BouncingCube2;
namespace BouncingCube2
{
public abstract class CommonUIText : MonoBehaviour
{
    [SerializeField] protected Text text;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        text = GetComponent<Text>();
    }

    public abstract void UpdateText();


    public virtual Text GetText()
    {
        return text;
    }
    public virtual string GetString()
    {
        return text.text;
    }

}}