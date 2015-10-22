using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
	public static int score;



	Text text;


	void Awake ()
	{

		text = GetComponent <Text> ();
		ScoreManager = 0;
	}

	void Update()
	{
		text.text = "Score:" + ScoreManager;
	}
}