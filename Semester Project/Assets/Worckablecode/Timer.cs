using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour 
{
	float timeRemaining = 30;

	void Start (){

	}

	void Update ()
	{
		timeRemaining -= Time.deltaTime;
		if(timeRemaining <=0)
		{
			Application.LoadLevel("GameOver2");
		}
	}
	void OnGUI()
	{
		if(timeRemaining > 0)
		{
			GUI.Label(new Rect(100, 100, 200, 100), "Time Remaining : "+(int)timeRemaining);
				}
		else
		{
			GUI.Label(new Rect(100, 100, 100, 100), "Time's up");
		}
	}
}
