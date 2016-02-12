using UnityEngine;
using System.Collections;

public class Spawn2 : MonoBehaviour
{
	public Rigidbody Duck2;
	public Transform Spawn;
	public float spawnTime = 3f;
	//public float timeBetweenSpawns = 2.0f;
	void Start ()
	{
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}

	void Update ()
	{
		Rigidbody Duckinstance;
		Duckinstance = Instantiate (Duck2, Spawn.position, Spawn.rotation)as Rigidbody;
		Duckinstance.AddForce(Spawn.up*50);
	}
}