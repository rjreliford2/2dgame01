using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    public GameObject hitNoisePrefab;

    private void Start()
    {
        Destroy(this.gameObject, 18f);
    }

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(hitNoisePrefab, this.transform.position, quaternion.identity);
        Destroy(this.gameObject);
    }
}
