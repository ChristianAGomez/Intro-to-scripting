﻿using UnityEngine;
using System.Collections;

public class BlockMovment : MonoBehaviour
{
	public Vector3 pointB;
	
	IEnumerator Start()
	{
		var pointA = transform.position;
		while(true)
		{
			yield return StartCoroutine(MoveObject(transform, pointA, pointB, 7.5f));
			yield return StartCoroutine(MoveObject(transform, pointB, pointA, 7.5f));
		}
	}
	
	IEnumerator MoveObject(Transform thisTransform, Vector3 startPos, Vector3 endPos, float time)
	{
		var i= 0.0f;
		var rate= 5.0f/time;
		while(i < 1.0f)
		{
			i += Time.deltaTime * rate;
			thisTransform.position = Vector3.Lerp(startPos, endPos, i);
			yield return null;
		}
	}
}