using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.Mathematics;


public class Pickup : MonoBehaviour
{   
    [SerializeField] 
    private TextMeshProUGUI itemgrab;
    private Inventory inventory;
    public GameObject itemButton;
    public GameObject itemNoisePrefab;
   // private bool item_can_be_grabbed;

    // Start is called before the first frame update
    private void Start()
    { 
       // itemgrab.gameObject.SetActive(false);
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>(); 
    }

   // private void Update()
   // {
     //   if (item_can_be_grabbed && Input.GetKeyDown(KeyCode.P))
       // {
         //   Grab_item();
        //}
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    //Item can be added to inventory
                   // item_can_be_grabbed = true;
                    //itemgrab.gameObject.SetActive(true);
                    inventory.isFull[i] = true;
                    Instantiate(itemButton, inventory.slots[i].transform, false);
                    Instantiate(itemNoisePrefab, this.transform.position, quaternion.identity);
                    Destroy(gameObject);
                    break;
                }
            }
                
        }
    }

   // private void OnTriggerExit2D(Collider2D collision)
    //{
     //   if (collision.CompareTag("Player"))
      //  {
       //     itemgrab.gameObject.SetActive(false);
        //    item_can_be_grabbed = false;
       // }
   // }
    
   // private void Grab_item()
   // {
       // inventory.isFull[0] = true;
      //  Instantiate(itemButton, inventory.slots[0].transform, false);
       // Destroy(gameObject);
   // }
}

