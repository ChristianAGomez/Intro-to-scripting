using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour 
{
	public float timeRemaining = 30;
    private ScoreManager myOtherClass;

	private int FinalScore = 0;

	void Start ()
	{
		FinalScore = 0;

		myOtherClass = new ScoreManager ();
		myOtherClass.score (FinalScore, myOtherClass.Score);
	}

	void Update ()
	{
		timeRemaining -= Time.deltaTime;
		if(timeRemaining <=0)
			if(Score <= 1&9)
		{
			Application.LoadLevel("Score 1-10");
				//Application.LoadLevel("GameOver");
		}
	}
}