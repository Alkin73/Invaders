using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int lives = 3;

    public TMP_Text livesText;
    // Start is called before the first frame update
    void Start()
    {
        livesText.text = "Lives: " + lives;
    }

    // Update is called once per frame
    void Update()
    {
        livesText.text = "Lives: " + lives;

        if (lives <= 0)
        {
            //lose screen
        }
    }
}
