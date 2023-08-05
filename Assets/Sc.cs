using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sc : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void sc1()
    {
        SceneManager.LoadScene(1);
    }
  
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "door")
        {
            SceneManager.LoadScene(2);
        }
        else if (collision.gameObject.tag == "sdoor")
        {
            SceneManager.LoadScene(3);
        }
    }
}
