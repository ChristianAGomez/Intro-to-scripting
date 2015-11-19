using UnityEngine;
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
		if (GUI.Button(new Rect(50,50,130,30),"DuckHunt")){
			Application.LoadLevel ("DuckHunt");}
	}
}