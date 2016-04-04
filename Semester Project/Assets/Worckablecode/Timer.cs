using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour 
{
	void time()
	{
		transform.position = new Vector3(0,0,0);
		print(transform.position.x);
	}
	public float timeRemaining = 30;
    private ScoreManager myOtherClass;
	public static int score;
	public int scoreValue = 0;

	void Start ()
	{
		/*scoreValue = 0;

		myOtherClass = new ScoreManager ();
		myOtherClass. (scoreValue, myOtherClass.score);
		GameObject Score = GameObject.Find ("Score");
		ScoreManager scoreManager = Score.GetComponent<ScoreManager> ();
		ScoreManager.score -= 0;
		scoreValue = 0;

		myOtherClass = new ScoreManager ();
		myOtherClass. (scoreValue, myOtherClass.score);*/
	}
	
	void Update ()
	{
		timeRemaining -= Time.deltaTime;
		if (timeRemaining <= 0)
			EndScore ();
	}

	public void EndScore()
	{

		if(scoreValue <=1)
		{
			Application.LoadLevel("Score 1-10");
				//Application.LoadLevel("GameOver");
		}
		else if(scoreValue <=9)
		{
			Application.LoadLevel ("Score 1-10");
		}

		if(scoreValue <=10)
		{
			Application.LoadLevel ("Score 10-20");
		}

		else if(scoreValue <=19)
		{
			Application.LoadLevel ("Score 10-20");
		}

		if(scoreValue <=20)
		{
			Application.LoadLevel ("Score 20-30");
		}

		else if(scoreValue <=29)
		{
			Application.LoadLevel ("Score 20-30");
		}

		if(scoreValue <=30)
		{
			Application.LoadLevel ("Score 30-40");
		}

		else if(scoreValue <=39)
		{
			Application.LoadLevel ("Score 30-40");
		}
	}
}