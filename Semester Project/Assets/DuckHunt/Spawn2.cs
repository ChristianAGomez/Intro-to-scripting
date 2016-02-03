using UnityEngine;
using System.Collections;

public class Spawn2 : MonoBehaviour
{
	public Rigidbody Duck2;
	public Transform Spawn;

	void Update ()
	{
		Rigidbody Duckinstance;
		Duckinstance = Instantiate (Duck2, Duck2.position, Duck2.rotation)as Rigidbody;
		Duckinstance.AddForce(Spawn.up*550);
	}
}