using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectiles : MonoBehaviour
{
    public GameObject projectile;

    public int damage = 40;
    public int speed = -5;
    public void Update()
    {
        transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(projectile);           
        }
        else if (collision.gameObject.tag == "Border")
        {
            Destroy(projectile);
        }
    }
}
