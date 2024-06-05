using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketPickUp : MonoBehaviour
{
    public Item Item;

    private void Pickup()
    {
        InventoryManager.Instance.Add(Item);
        Destroy(gameObject);
    }

    private void OnMouseDown()
    {
        
        
            Pickup();
        
    }
}
