using UnityEngine;
using System.Collections;

public class Foreach : MonoBehaviour
{
	void Start ()
	{
		string[] strings = new string[5];

		strings[0] = "First string";
		strings[3] = "Second string";
		strings[4] = "Thrird string";

		foreach(string item in strings)
		{
			print (item);
		}
	}
}