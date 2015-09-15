using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour 
{
	int myInt = 10;


	void Start ()
	{
		myInt = AddByTwo (myInt);
		Debug.Log (myInt);
	}


	int AddByTwo (int number)
	{
		int ret;
		ret = number +10;
		return ret;
	}
}