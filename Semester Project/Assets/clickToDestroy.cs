using UnityEngine;
using System.Collections;

public class clickToDestroy : MonoBehaviour {

	void OnMouseDown ()
	{
		Destroy(gameObject);
	}
}