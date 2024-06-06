using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEnable : MonoBehaviour
{
    public GameObject button;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Player")
        {
            button.SetActive(true);
        }
        else
        {
            button.SetActive(false);
        }
    }
}
