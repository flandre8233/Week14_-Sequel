using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BouncingCube2;
namespace BouncingCube2
{
public class ViewMovement : MonoBehaviour
{
    [SerializeField] Vector2 StartVal;
    [SerializeField] Vector2 WantedVal;
    [SerializeField] float CurrentTime;
    [SerializeField] float FinishTime;

private void Update() {
      CurrentTime += Time.deltaTime;
        CurrentTime = Mathf.Clamp(CurrentTime, 0, FinishTime);
        StartVal = Vector2.Lerp(StartVal, new Vector2(), CurrentTime / FinishTime);
        transform.localPosition = new Vector3(StartVal.x, StartVal.y, 0);

}

    // Start is called before the first frame update
    void Start()
    {
        FinishTime += Random.Range(-0.21f, 0.21f);
        Vector2 RandomViewPort = Random.insideUnitCircle.normalized * Random.Range(1.1f, 1.3f);
        Vector3 WorldPos = Camera.main.ViewportToWorldPoint(RandomViewPort);
        StartVal = new Vector3(WorldPos.x, WorldPos.y, 0);
    }

}
}