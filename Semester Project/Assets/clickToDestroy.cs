using UnityEngine;
using System.Collections;

public class clickToDestroy : MonoBehaviour
{
	public int scoreValue = 10;

	void OnMouseDown ()
		{
			Destroy(gameObject);
			ScoreManager.score += scoreValue;
	}
}
