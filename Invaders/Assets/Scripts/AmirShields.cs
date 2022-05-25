using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmirShields : MonoBehaviour
{
	//not finished , need to make it apply on the char
	public bool shielded = false;
	public float cooldownTime = 10f;
	public float offCooldown = 0;
	public float cooldownUI = 0;

	public Text uiText;

	private void Start()
	{
		shielded = false;
	}
	private void Update()
	{
		if (offCooldown < Time.time)
		{
			if (Input.GetKeyDown(KeyCode.LeftShift))// input
			{
				if (!shielded)//checks if not shielded already
				{
					StartCoroutine(getShield());
					offCooldown = Time.time + cooldownTime;
				}
			}
			uiText.text = "Shield is ready !"; //display text if ready
		}
		else if (offCooldown >= Time.time)
		{
			cooldownUI = offCooldown - Time.time;
			uiText.text = "cooldownTime : " + cooldownUI; //display text if not ready
		}

	}

	private IEnumerator getShield()// shield for 1.5 seconds and then unshielded
	{
		shielded = true;
		yield return new WaitForSeconds(1.5f);
		shielded = false;
	}
}