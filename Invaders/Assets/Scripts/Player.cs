using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerProjectiles weapon1;
    public PlayerProjectiles weapon2;

    public float horizontalSpeed = 2.0f;
    public float edge = 0;

    public bool isOnSecondWeapon;

    public void Start()
    {
        isOnSecondWeapon = false;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnSecondWeapon == false)
        {
            ShootFirstWeapon();
        }
        else if(Input.GetKeyDown(KeyCode.Space) && isOnSecondWeapon == true)
        {
            ShootSecondWeapon();
        }

        if (Input.GetKeyDown(KeyCode.LeftShift) && isOnSecondWeapon == false)
        {
            isOnSecondWeapon = true;
        }
        else if(Input.GetKeyDown(KeyCode.LeftShift) && isOnSecondWeapon == true)
        {
            isOnSecondWeapon = false;
        }
    }

    //first weapon
    private void ShootFirstWeapon()
    {
        Instantiate(this.weapon1, this.transform.position, Quaternion.identity); 
    }

    private void ShootSecondWeapon()
    {
        Instantiate(this.weapon2, this.transform.position, Quaternion.identity);

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
