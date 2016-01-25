﻿using UnityEngine;
using System.Collections;

public class LeaderBoard : MonoBehaviour
{
	public int highScore;
	string highScoreKey = "HighScore";
	void Start ()
	{
		highScore = PlayerPrefs.GetInt (highScoreKey,0);
	}
}