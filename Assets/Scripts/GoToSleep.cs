using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToSleep : MonoBehaviour
{
    public bool isAwake;

    void Update()
    {
        if (Input.GetKeyDown("space"))
		{
			isAwake = !isAwake;
			if (isAwake == false)
			{
				Debug.Log("Rév is asleep");
				
			}
			else
			{
				Debug.Log("Rév is awake");
			}	
		}
    }

	private void OnCollisionEnter2D(Collision2D collision)
	{
        if (collision.gameObject.tag == "door")
        {
            SceneManager.LoadScene(1);
        }
    }
}
