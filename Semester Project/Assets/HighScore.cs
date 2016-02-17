using UnityEngine;
using System.Collections;

public class HighScore : MonoBehaviour
{
	void StoreHighscore(int newHighscore)
{
	int oldHighscore = PlayerPrefs.GetInt("highscore", 0);    
	if(newHighscore > oldHighscore)
		PlayerPrefs.SetInt("highscore", newHighscore);
	}
}