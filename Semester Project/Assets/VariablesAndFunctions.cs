using UnityEngine;
using System.Collections;

 public class VariablesAndFunctions : MonoBehaviour
{
	int myint = 5;


	void Start ()
	{
		myint = AddByTwo(myint);
		Debug.Log (myint);
	}


	int AddByTwo (int number)
	{
		int ret;
		ret = number + 8;
		return ret;
	}
}