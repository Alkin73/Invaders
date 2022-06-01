using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerProjectiles weapon;

    public float horizontalSpeed = 2.0f;
    public float edge = 0;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    //first weapon
    private void Shoot()
    {
        Instantiate(this.weapon, this.transform.position, Quaternion.identity); 
    }

    private void FixedUpdate()
    {
        float movex = Input.GetAxis("Horizontal") * horizontalSpeed * Time.fixedDeltaTime;
        transform.position += new Vector3(movex, 0);
        if (transform.position.x >= edge)
        {
            transform.position = new Vector3(edge, transform.position.y, 0);
        }
        else if (transform.position.x <= -edge)
        {
            transform.position = new Vector3(-edge, transform.position.y, 0);
        }
    }
}
