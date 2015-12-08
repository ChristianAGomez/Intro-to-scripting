using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour 
{
	float timeRemaining = 20;

	void Start (){

	}

	void Update ()
	{
		timeRemaining -= Time.deltaTime;
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