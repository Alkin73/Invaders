using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public GameObject enemyProjectile;
    Vector2 respawn = new Vector2(0, -4.45f);

    public int speed = -5;
    public void Update()
    {
        transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.transform.position = respawn;
            Destroy(enemyProjectile);
            GameManager.lives--;
        }
        else if (collision.gameObject.tag == "Border")
        {
            Destroy(enemyProjectile);
        }
    }
}
