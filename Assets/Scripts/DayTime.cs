using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayTime : MonoBehaviour
{
    public bool night;
    public float timePassed;
    public float timeInDay;
    
    void Start()
    {   
        night = true;
        Debug.Log("Day");
    }
    void Update()
    {
       timePassed += Time.deltaTime;
       if(timePassed >= (timeInDay))
       {
         if(night)
         {
            Debug.Log("Night");
            timePassed = 0.0f;
            night = false;
         }
         else
         {
            Debug.Log("Day");
            timePassed = 0.0f;
            night = true;
         }
       }
    }
}
