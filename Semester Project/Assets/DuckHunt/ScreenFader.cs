using UnityEngine;
using System.Collections;

public class ScreenFader : MonoBehaviour
{
	public GUIText gameOverText;
	public GUIText MainMenuText;
	
	private bool gameOver;
	private bool MainMenu;
	private int score;
	
	Animator anim;
	//float restartTimer;
	
	void Start ()
	{
		gameOver = false;
		MainMenu = false;
		//MainMenuText.text = "";
		//gameOverText.text = "";
		score = 0;
	}
	
	
	void Awake ()
	{
		anim = GetComponent <Animator> ();
	}

	void OnGUI()
	{
		{
			GUI.Label(new Rect(100, 100, 100, 100), "Time's up");
		}
	}
}
