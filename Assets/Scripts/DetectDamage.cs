using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class DetectDamage : MonoBehaviour
{
    public float maxhealth = 4f;
    public float health;
    private Image _healthBarFill;
    public HealthBar healthBar;

    public DetectDamage()
    {
        healthBar = gameObject.AddComponent<HealthBar>();
    }


    void Update()
    {
        if (maxhealth < 1)
        {
            Die();
        }
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<IsSpike>())
        {
            Die();
        }

        if (other.GetComponent<Projectile>())
        {
            TakeDamage();

        }
    }

    public void TakeDamage()
    {
        health--;
        healthBar.UpdateHealthBar();
    }
    
    public void Die()
    {
        Destroy(this.gameObject);
        SceneManager.LoadScene("Dream_World_Platformer");
    }
}


