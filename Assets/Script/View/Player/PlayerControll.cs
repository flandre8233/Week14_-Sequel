using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BouncingCube2;
namespace BouncingCube2
{
public class PlayerControll : SingletonMonoBehavior<PlayerControll>
{
    [SerializeField]
    GameObject PlayerObject;
    [SerializeField]
    BackgroundClick BackGroundDetect;

    public CubeMovement movement;
    public CubeColor color;

    public void OnPlayerLose()
    {
        StatusControll.ToNewStatus(new GameoverStatus());
        Destroy(PlayerObject.gameObject);
    }

    public void OnPlayerClickBouningCube()
    {
        Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 BallPos = movement.transform.position;
        MousePos = new Vector3(MousePos.x, MousePos.y, 0);
        BallPos = new Vector3(BallPos.x, BallPos.y, 0);
        float Distance = Vector3.Distance(MousePos, BallPos);
        float Score = CubeScoreCounter.instance.GetDisantceScore() * (1 - (Distance / 1.5f));

        movement.SetStart();
        BackGroundDetect.gameObject.SetActive(true);
        color.enabled = true;

        color.ResetColor();
        ShakeControll.CameraStart(0.5f, 0.3f);
        ShakeControll.GameCanvasStart(0.5f, 30f);
        movement.CubeAddForce();
        ScoreCounter.instance.Floating++;
        ScoreCounter.instance.OnPlayerGetScore(Mathf.RoundToInt(Score), PlayerObject.transform.position);
        comboPass.enabled = true;
        ScoreBallSpawner.instance.Clear();
        ScoreBallSpawner.instance.DelaySpawn();
        ScoreBallSpawner.instance.DelaySpawn();

        ResourcesSpawner.Spawn("Explosion", PlayerObject.transform.position, 5f);
    }

    [SerializeField] ComboPass comboPass;

    public void OnPlayerClickScoreBall(Transform BallTrans)
    {
        Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 BallPos = BallTrans.position;
        MousePos = new Vector3(MousePos.x, MousePos.y, 0);
        BallPos = new Vector3(BallPos.x, BallPos.y, 0);
        float Distance = Vector3.Distance(MousePos, BallPos);
        float Score = 1 * (1 - (Distance / 1.5f));

        ScoreCounter.instance.AddCombo();
        ShakeControll.CameraStart(0.25f, 0.1f);
        ShakeControll.GameCanvasStart(0.25f, 10f);
        ScoreCounter.instance.OnPlayerGetScore(Mathf.RoundToInt(Score), BallTrans.position);
        ScoreBallSpawner.instance.Spawn();
    }

    public GameObject GetPlayerObject()
    {
        return PlayerObject;
    }

}
}