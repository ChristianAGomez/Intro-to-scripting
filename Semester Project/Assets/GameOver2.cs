using UnityEngine;
using System.Collections;

public class GameOver2 : MonoBehaviour
{
	public GUIText restartText;
	public GUIText GameOverText;

	private bool GameOver;
	private bool restart;
	private int score;

	void Start ()
	{
		GameOver = false;
		restart = false;
		restartText.text = "";
		GameOverText.text = "";
		Score = 0;
		UpdateScore();
	}

	void Update ()
	{
		if (restart)
		{
			restartText = restartText.GetComponent<Button> ();
		}
	}
	public void AddScore (int newScoreValue)
	{
		score += newScoreValue;
		UpdateScore ();
	}

	Void UpdateScore ()
	{
		scoreText.text = "Score: " + score;
	}

	public void GameOver ()
	{
		GameOverText.text = "Game Over!";
		GameOver = true;
	}
}
