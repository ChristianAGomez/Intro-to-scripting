using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuButton : MonoBehaviour
{
	public Button MenuText;
	
	void Start ()
	{
		MenuText = MenuText.GetComponent<Button> ();
	}
	
	public void OnGUI()
	{
		if (GUI.Button(new Rect(Screen.width/2-50, Screen.height/2-25, 100, 50),"Menu")){
			Application.LoadLevel ("Menu");}
	}
}