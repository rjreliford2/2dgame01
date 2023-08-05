using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items
{
    public enum ItemType{
        key,
        dream_essence,
        letter,
        chocolate_milk
    }

    public ItemType itemType;
    public int amount;

}