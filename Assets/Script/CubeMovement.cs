using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BouncingCube2;
namespace BouncingCube2
{
public class CubeMovement : SingletonMonoBehavior<CubeMovement>
{
    [SerializeField] Rigidbody2D Rigidbody2D;

    public void SetStart()
    {
        Rigidbody2D.gravityScale = .5f;
    }

    public void CubeAddForce()
    {
        Vector2 RandomDir = DegreeToVector2(Random.Range(75f, 105f));
        Rigidbody2D.velocity = new Vector2();
        Rigidbody2D.AddForce(RandomDir * 9.8f, ForceMode2D.Impulse);
    }

    public static Vector2 DegreeToVector2(float degree)
    {
        return RadianToVector2(degree * Mathf.Deg2Rad);
    }

    public static Vector2 RadianToVector2(float radian)
    {
        return new Vector2(Mathf.Cos(radian), Mathf.Sin(radian));
    }

}}
