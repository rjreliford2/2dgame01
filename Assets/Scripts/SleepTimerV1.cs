using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepTimerV1 : MonoBehaviour
{
    public GoToSleep boolHolder;
    private float timer;
    void Start()
    {
        InvokeRepeating("TimeCheck", 10, 10);
    }
    void Update()
    {
        if (boolHolder.isAwake == false)
        {
            timer += 1f * Time.deltaTime;
        }
    }
    void TimeCheck()
    {
        Debug.Log("Time spent sleeping: " + timer + " seconds");
    }
}
