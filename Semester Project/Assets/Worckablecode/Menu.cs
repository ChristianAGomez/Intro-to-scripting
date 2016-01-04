﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Menu : MonoBehaviour
{
	public Button startText;

	void Start ()
	{
		startText = startText.GetComponent<Button> ();
	}

	public void OnGUI()
	{
		if (GUI.Button(new Rect(Screen.width/2-50, Screen.height/2-25, 100, 50),"DuckHunt")){
			Application.LoadLevel ("DuckHunt");}
	}
}