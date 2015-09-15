using UnityEngine;
using System.Collections;

public class Syntix : MonoBehaviour
{
	int myint = 5;


	int MyFunction (int number)
	{
		int ret = myint * number;
		return ret;
	}
}