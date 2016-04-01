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

	public int scoreValue = 0;

	void Start ()
	{
		GameObject Score = GameObject.Find ("Score");
		ScoreManager scoreManager = Score.GetComponent<ScoreManager> ();
		ScoreManager.score -= 0;
		/*FinalScore = 0;

		myOtherClass = new ScoreManager ();
		myOtherClass.ScoreManager (FinalScore, myOtherClass.Score);*/
	}
	
	void Update ()
	{
		timeRemaining -= Time.deltaTime;
		if (timeRemaining <= 0)
			EndScore ();
	}

	public void EndScore()
	{

		if(scoreValue >=9)
		{
			Application.LoadLevel("Score 1-10");
				//Application.LoadLevel("GameOver");
		}

		else if(scoreValue >=19)
		{
			Application.LoadLevel ("Score 10-20");
		}
	}
}