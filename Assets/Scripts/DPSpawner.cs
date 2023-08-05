using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class DPSpawner : MonoBehaviour
{
    public GameObject projectile;
    void Start()
    {
        InvokeRepeating("Spawn",0f,0.8f);
    }

    void Spawn()
    {
        float height = UnityEngine.Random.Range(0.1f, 4.0f);
        Instantiate(projectile, new Vector2(this.transform.position.x, this.transform.position.y + height), quaternion.identity);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(this.gameObject);
    }
}
