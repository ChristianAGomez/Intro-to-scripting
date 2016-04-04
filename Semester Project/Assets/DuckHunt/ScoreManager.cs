using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class ScoreManager : MonoBehaviour
{
	public static int score;
	public static int scoreValue;


	Text text;


	void Awake ()
	{

		text = GetComponent <Text> ();
		score = 0;
		scoreValue = 0;
	}

	void Update ()
	{
		text.text = "Score:" + score;
		scoreValue = score;

	}
}