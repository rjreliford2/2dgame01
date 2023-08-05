using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    public ChocolateMilkBool milk;
    public GameObject winNoisePrefab;
    // Update is called once per frame
    private void Update()
    {
        if (milk.isPickedUp)
        {
            BeatLevel1();
        }
    }
    
    private void BeatLevel1()
    {
        Instantiate(winNoisePrefab, this.transform.position, quaternion.identity);
        SceneManager.LoadScene("Dream_World_Platformer");
    }
}
