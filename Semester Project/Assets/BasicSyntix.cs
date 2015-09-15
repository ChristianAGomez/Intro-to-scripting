using UnityEngine;
using System.Collections;

public class BasicSyntix : MonoBehaviour
{
	void Start ()
	{
		Debug.Log (transform.position.x);


		if(transform.position.y <= 5f)
		{
			Debug.Log ("HI!!!!!!!!!");
		}
	}
}