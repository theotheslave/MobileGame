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
        void OnTriggerEnter(Collider collision)
        {
            if(collision.CompareTag("trash"))
            {
                Destroy(collision.gameObject);
            }

            if(collision.CompareTag("bucket"))
            {
                Destroy(collision.gameObject);
            }
        }

    }

