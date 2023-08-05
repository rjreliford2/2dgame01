using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChocolateMilkBool : MonoBehaviour
{
    public bool isPickedUp;

    private void OnEnable()
    {
        isPickedUp = true;
    }
}
