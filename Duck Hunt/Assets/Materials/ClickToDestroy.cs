using UnityEngine;
using System.Collections;

public class ClickToDestroy : MonoBehaviour
{
	public int scoreValue = 1;
	void Start ()
	{
		Destroy (gameObject, 3f);
	}
	void OnMouseDown ()
	{
		Destroy(gameObject);
	}
}