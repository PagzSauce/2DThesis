
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimers : MonoBehaviour
{
    float currentTime = 0f;
    public float startingTime = 10f;

    void start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        print (currentTime);
    }
}
