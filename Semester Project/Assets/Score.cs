using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour
{
	public int score = 0;
	public int highScore = 0;
	string highScoreKey = "HighScore";
	
	void Start()
	{
		highScore = PlayerPrefs.GetInt (highScoreKey,0);
	}
	
	void Update()
	{
		GUIText.text = "Score:" + score.ToString();
	}
	
	void onDisable(){
		if(score>highScore)
		{
			PlayerPrefs.SetInt (highScoreKey, score);
			PlayerPrefs.Save ();
		}
	}
}