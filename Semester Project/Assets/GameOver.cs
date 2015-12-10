using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOver : MonoBehaviour
{
	public Button GameOverText;
	
	void Start ()
	{
		GameOverText = GameOverText.GetComponent<Button> ();
	}
	
	public void OnGUI()
	{
		if (GUI.Button(new Rect(140,100,130,30),"DuckHunt")){
			Application.LoadLevel ("DuckHunt");}
	}
}