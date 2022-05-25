using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D enemyProjectile;

    public float projSpeed = 5;

    public void Update()
    {
        EnemyShooting();
    }

    public void EnemyShooting()
    {
        if (Random.Range(0f, 1500) < 1)
        {
            Rigidbody2D obj = Instantiate(enemyProjectile);
            obj.transform.position = transform.position;
            obj.velocity = Vector2.down * projSpeed;
        }
    }
}
