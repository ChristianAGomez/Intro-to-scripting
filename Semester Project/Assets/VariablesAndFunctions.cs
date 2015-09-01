using UnityEngine;
using System.Collections;

 public class VariablesAndFunctions : MonoBehaviour
{
	int myInt = 49;


	void Start ()
	{
		myInt = MultiplyByTwo (myInt);
		Debug.Log (myInt);
	}


	int MultiplyByTwo (int number)
	{
		int ret;
		ret = number * 50;
		return ret;
	}
}