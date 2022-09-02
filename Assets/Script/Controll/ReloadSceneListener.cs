using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using BouncingCube2;
namespace BouncingCube2
{
public class ReloadSceneListener : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) )
        {
            SceneManager.LoadScene(0, LoadSceneMode.Single);
        }
    }
}
}