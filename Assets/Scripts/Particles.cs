using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other) {
        GetComponent<ParticleSystem>().Play();
    } 
    
}
