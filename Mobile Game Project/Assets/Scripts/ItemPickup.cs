using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    
    public Item Item;
    private bool pickable = false; 
   public void Pickup()
    {
        if ( pickable = true){
        InventoryManager.Instance.Add(Item);
        Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            
            pickable = true;
            Debug.Log("help");
        }
        else
        {
            pickable = false;
            
            Debug.Log("WTF");
        }
    }
}
