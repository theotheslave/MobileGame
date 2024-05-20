using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == ("trash"))
        {
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.tag == ("bucket"))
        {
            Destroy(collision.gameObject);
        }
    }

}
