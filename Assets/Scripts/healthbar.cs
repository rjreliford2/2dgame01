using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image healthbarfill;
    public DetectDamage player;
    
    public void UpdateHealthBar() {
        healthbarfill.fillAmount = Mathf.Clamp(player.health / player.maxhealth, 0, 1f);
    }
}


