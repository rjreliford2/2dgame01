using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerNoise : MonoBehaviour
{
    public AudioSource clipSource;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<IsRev>())
        {
            clipSource.Play();
        }
    }
}
