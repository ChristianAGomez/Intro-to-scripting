using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour
{
	void example ()
	{
		print(PlayerPrefs.GetInt("playerscore"));
	}
}