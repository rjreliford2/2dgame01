using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel2 : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.GetComponent<IsRev>())
        {
            if (Input.GetKeyDown("e"))
            {
                SceneManager.LoadScene("OutroStory");
            }
        }
    }
}
