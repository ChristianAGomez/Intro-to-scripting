using UnityEngine;
using System.Collections;

public class clickToDestroy : MonoBehaviour
{
	public int scoreValue = 1;

	public ScoreManager myOtherClass;

	void Start ()
	{
		//Score = 0;
		Destroy (gameObject, 1.8f);
		//scoreValue.GetComponent<ScoreManager> ().MyFunction ();
		//myOtherClass = new ScoreManager ();
		//myOtherClass.Score (Score, myOtherClass.Score);
	}
	void OnMouseDown ()
		{
			Destroy(gameObject);
		ScoreManager.score += scoreValue;
		Timer.score += scoreValue;
		ScoreManager.FinalScore += scoreValue;
	}
}