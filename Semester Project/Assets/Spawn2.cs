using UnityEngine;
using System.Collections;

public class Spawn2 : MonoBehaviour
{
	public Rigidbody Duck;
	public Transform Spawn;

	void Update ()
	{
		Rigidbody Duckinstance;
		Duckinstance = Instantiate (Duck, Duck.position, Duck.rotation)as Rigidbody;
		Duckinstance.AddForce(Spawn.up*1f);
	}
}