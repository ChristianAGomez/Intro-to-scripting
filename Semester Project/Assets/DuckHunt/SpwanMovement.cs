﻿using UnityEngine;
using System.Collections;

public class SpwanMovement : MonoBehaviour
{
	public Vector3 pointB;

IEnumerator Start()
{
	var pointA = transform.position;
	while(true)
	{
		yield return StartCoroutine(MoveObject(transform, pointA, pointB, 3.5f));
		yield return StartCoroutine(MoveObject(transform, pointB, pointA, 3.5f));
	}
}

IEnumerator MoveObject(Transform thisTransform, Vector3 startPos, Vector3 endPos, float time)
{
	var i= 0.0f;
	var rate= 25.0f/time;
	while(i < 1.0f)
	{
		i += Time.deltaTime * rate;
		thisTransform.position = Vector3.Lerp(startPos, endPos, i);
		yield return null;
		}
	}
}