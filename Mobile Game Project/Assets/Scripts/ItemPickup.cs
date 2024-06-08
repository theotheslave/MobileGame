using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    
    public Item Item;
    private bool pickable = false; 
   

    private void OnTiggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Player")
        {
            
            pickable = true;
            Debug.Log("help");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            
            pickable = false;
            Debug.Log("help");
        }
    }
    public void Pickup()
    {
        if ( pickable == true){
            InventoryManager.Instance.Add(Item);
            Destroy(gameObject);
        }
    }
}
