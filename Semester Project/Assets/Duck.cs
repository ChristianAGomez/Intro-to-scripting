using UnityEngine;

public class Duck : MonoBehaviour
{
	public float sinkSpeed = 2.5f;
	public int scoreValue = 1;
	
	bool isSinking;

	void Example()
	{
		transform.position += Vector3.up * Time.deltaTime;
	}
}
	void Update ()
	{
		if(isSinking)
		{
			Transform.Translate (-Vector3.up * sinkSpeed * Time.deltaTime);
		}
	}

	public void StartSinking()
	{
		isSinking = true;
		ScoreManager.score += scoreValue;
}