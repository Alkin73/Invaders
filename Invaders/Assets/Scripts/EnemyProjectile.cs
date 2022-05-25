using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public GameObject enemyProjectile;
    public AmirShields Shield;
    public int speed = -5;
    public void Update()
    {
        transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (Shield) //not finished , figuring out how to build the condition for checking if player is shielded or not (getting component from AmirShields for reference) [comment by amir]
            {

            }
            else
            {
                Destroy(collision.gameObject);
                Destroy(enemyProjectile);
            }   
        }
        else if (collision.gameObject.tag == "Border")
        {
            Destroy(enemyProjectile);
        }
    }

}
