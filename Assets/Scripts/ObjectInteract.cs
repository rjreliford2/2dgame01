using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObjectInteract : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            Debug.Log("Rév is interacting with an object!");
        }
    }
}
