using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour 
{
	public float timeRemaining = 30;
	public GUIText gameOverText;
	public float restartDelay = 5f;
	//public GUIText MainMenuText;

	private bool gameOver;
	private bool MainMenu;
	private int score;

	Animator anim;
	float restartTimer;

	void Start (){
		gameOver = false;
		MainMenu = false;
		//MainMenuText.text = "";
		gameOverText.text = "";
		score = 0;
	}
	
	
	void Awake ()
	{
		anim = GetComponent <Animator> ();
	}

	void Update ()
	{
		timeRemaining -= Time.deltaTime;
		if(timeRemaining <=0)
		{
			anim.SetTrigger ("GameOver");
			restartTimer += Time.deltaTime;
			if(restartTimer >= restartDelay)
			{
				Application.LoadLevel (Application.loadedLevel);
			}
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
