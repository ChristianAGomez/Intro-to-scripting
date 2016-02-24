using UnityEngine;
using System.Collections;

public class GameOver2 : MonoBehaviour
{
	public Timer;
	public float restartDelay = 5f;

	float restartTimer;

	void Update ()
	{
		if(Timer.timeRemaining <=0)
		{
			restartTimer =+ Time.deltaTime;

			if(restartTimer >= restartDelay)
			{
				Application.LoadLevel(Application.loadedLevel);
			}
		}
	}
}
