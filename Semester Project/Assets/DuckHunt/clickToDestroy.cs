﻿using UnityEngine;
using System.Collections;

public class clickToDestroy : MonoBehaviour
{
	public int scoreValue = 1;
	void Start ()
	{
		Destroy (gameObject, 1f);
	}
	void OnMouseDown ()
		{
			Destroy(gameObject);
			ScoreManager.score += scoreValue;
	}
}