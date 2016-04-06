using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class ScoreManager : MonoBehaviour
{
	public static int score;
	public static int FinalScore;


	Text text;


	void Awake ()
	{

		text = GetComponent <Text> ();
		score = 0;
		FinalScore = 0;
	}

	void Update ()
	{
		text.text = "Score:" + score;

	}
}