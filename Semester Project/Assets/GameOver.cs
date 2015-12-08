using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour
{
	public float restartdelay = 5f

		Animator Animator;
	float restartTimer;

	void Update ()
	{
		restartTimer += Time.deltaTime;

		if(restartTimer) >= restartDelay)
		{

			Application.LoadLevel(Application.loadedLevel);
		}
	}
}