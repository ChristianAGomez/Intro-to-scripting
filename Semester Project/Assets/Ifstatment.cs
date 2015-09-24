using UnityEngine;
using System.Collections;

public class Ifstatment : MonoBehaviour
{
    float HighJump = 85.0f;
    float NormalLimitJump = 70.0f;
    float LowLimitJump = 40.0f;



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            JumpTest();

        HighJump -= Time.deltaTime * 5f;
        Debug.Log(HighJump);
    }

    void JumpTest()
    {
        if (HighJump > NormalLimitJump)
        {
            print("I can fly!");
        }
        else if (HighJump < LowLimitJump)
        {
            print("Who needs to jump?");
        }
        else
        {
            print("eh nothing special.");
        }
    }
}

