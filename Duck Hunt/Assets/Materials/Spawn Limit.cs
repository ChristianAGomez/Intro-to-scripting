using UnityEngine;
using System.Collections;

public class SpawnLimit : MonoBehaviour
{
	private int enemyCount = 0;
public int maxEnemyCount = 12;
public float timeBetweenSpawns = 2.0f;

void Start()
	{
	InvokeRepeating("Spawn", 0, timeBetweenSpawns);
}

void Spawn()
	{
	
	//Your instantiate stuff here
	
	enemyCount++;
	if(enemyCount>=maxEnemyCount)
		{
		ClickDestroy("Spawn");
		}
	}
}