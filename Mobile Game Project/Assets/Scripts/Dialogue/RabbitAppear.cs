using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitAppear : MonoBehaviour
{
    public GameObject rabbit1;
    public GameObject rabbit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Destroy(rabbit); 
        }
        rabbit1.SetActive(true);
        
    }
}
