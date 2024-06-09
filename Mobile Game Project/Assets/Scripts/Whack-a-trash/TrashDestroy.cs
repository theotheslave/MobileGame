using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashDestroy : MonoBehaviour
{
    public void OnMouseDown()
    {
        Destroy(gameObject);


    }
    
    void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("wall"))
        {
            Destroy(gameObject);
        }

      
    }


    
}


