using UnityEngine;
using System.Collections;

public class DuckSpawn : MonoBehaviour
{
	public GameObject Cube;
	public float spawnTime = 10f;
	public Transform[] spawnPoints;

	void Start ()
	{
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
		GameObject.FindGameObjectWithTag ("Spawns");
	}

	void Spawn()
	{

		int Spawn = Random.Range (0, spawnPoints.Length);

		Instantiate (Cube, spawnPoints[Spawn].position, spawnPoints[Spawn].rotation);
	}
}
	