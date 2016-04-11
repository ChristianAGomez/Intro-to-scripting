using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class ScoreManager : MonoBehaviour
{
	public static int score;
	public static int FinalScore; 



	//bool destroy;
	Text text;


	void Awake ()
	{
		/*if (destroy == true)
		destroy = GetComponent ();*/

		text = GetComponent <Text> ();
		score = 0;
		FinalScore = 0;
	}

	void Update ()
	{
		text.text = "Score:" + score;
		 FinalScore = score;
		//destroy.destroy = "FinalScore" + score;

	}
}