using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour 
{
	public float timeRemaining = 5;

	void Update ()
	{
		timeRemaining -= Time.deltaTime;
		if(timeRemaining <=0)
		{
				Application.LoadLevel("GameOver");
		}
	}
}