using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour 
{
 	void time()
	{
		/*transform.position = new Vector3(0,0,0);
		print(transform.position.x);*/
	}
	public float timeRemaining = 30;
	public float FinalScore = 0;
    //public ScoreManager myOtherClass;
	public static int score;
	//public static int FinalScore;

	void Start ()
	{

	}
	
	void Update ()
	{
		timeRemaining -= Time.deltaTime;
		if (timeRemaining >= 0)
			EndScore ();
	}

	public void EndScore()
	{
		if ( FinalScore >= 1)
		{
			Application.LoadLevel("Score 1-10");
				//Application.LoadLevel("GameOver");
		}
		else if( FinalScore >=9)
		{
			Application.LoadLevel ("Score 1-10");
		}

		if( FinalScore >=10)
		{
			Application.LoadLevel ("Score 10-20");
		}

		else if( FinalScore >=19)
		{
			Application.LoadLevel ("Score 10-20");
		}

		if( FinalScore >=20)
		{
			Application.LoadLevel ("Score 20-30");
		}

		else if( FinalScore >=29)
		{
			Application.LoadLevel ("Score 20-30");
		}

		//if (FinalScore <= 30) 
		//{
		//	Application.LoadLevel ("Score 30-40");
		//}
	}
}

