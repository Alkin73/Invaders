using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public GameObject enemyProjectile;

    public int speed = -5;
    public void Update()
    {
        transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            Destroy(enemyProjectile);
        }
        else if (collision.gameObject.tag == "Border")
        {
            Destroy(enemyProjectile);
        }
    }
}
