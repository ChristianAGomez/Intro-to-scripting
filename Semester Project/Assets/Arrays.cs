using UnityEngine;
using System.Collections;

public class Arrays : MonoBehaviour
{
	public GameObject[] Cube;

	void Start ()
	{
		Cube = GameObject.FindGameObjectsWithTag("Cube");

		for(int i = 0; i < Cube.Length; i++)
		{
			Debug.Log ("Cube number "+i+" is nambed "+Cube[i].name);
		}
	}
}