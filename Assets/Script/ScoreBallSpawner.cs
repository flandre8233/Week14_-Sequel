using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BouncingCube2;
namespace BouncingCube2
{
public class ScoreBallSpawner : SingletonMonoBehavior<ScoreBallSpawner>
{
    List<ScoreBall> ScoreBalls = new List<ScoreBall>();
    public void Spawn()
    {
        GameObject SpawnedObject = ResourcesSpawner.Spawn("ScoreBall", GetRandomSpawnPosition());
        ScoreBalls.Add(SpawnedObject.GetComponent<ScoreBall>());
    }

    public void DelaySpawn()
    {
        Invoke("Spawn", Random.Range(0.0f, 0.51f));
    }

    Vector3 GetRandomSpawnPosition()
    {
        Vector2 RandomViewPort = Random.insideUnitCircle * 0.4f;
        RandomViewPort = new Vector2(RandomViewPort.x + 0.5f, RandomViewPort.y + 0.5f);
        Vector3 WorldPoint = Camera.main.ViewportToWorldPoint(RandomViewPort);
        return new Vector3(WorldPoint.x, WorldPoint.y, 0);
    }

    public void Clear()
    {
        foreach (var item in ScoreBalls)
        {
            if (item)
            {
                Destroy(item.gameObject);
            }
        }
        ScoreBalls = new List<ScoreBall>();
    }
}
}