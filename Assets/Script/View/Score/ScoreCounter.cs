using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BouncingCube2;
namespace BouncingCube2
{
public class ScoreCounter : SingletonMonoBehavior<ScoreCounter>
{
    public int Floating;
    public int Score;
    int MaxCombo;
    int Combo;

    [SerializeField] CommonUIText ScoreUI;
    [SerializeField] CommonUIText ComboUI;
    [SerializeField] CommonUIText FloatingUI;

    public void ResetCombo()
    {
        Combo = 0;
    }
    public void AddCombo()
    {
        Combo++;
        if (Combo > MaxCombo)
        {
            MaxCombo = Combo;
        }
    }
    public int GetCombo()
    {
        return Combo;
    }
    public int GetMaxCombo()
    {
        return MaxCombo;
    }

    public void OnPlayerGetScore(int AddScore, Vector3 AddScorePosition)
    {
        int TotalAddScore = Mathf.RoundToInt(AddScore * Combo * (1 + (0.1f * Floating)));
        Score += TotalAddScore;

        ScoreUI.UpdateText();
        if (Combo > 0)
        {
            ComboUI.UpdateText();
        }
        ReflectSoundSpawner.Spawn();
        if (Score > 0)
        {
            CommectControll.instance.OnPlayerReflecting(TotalAddScore, AddScorePosition);
        }
    }

}
}