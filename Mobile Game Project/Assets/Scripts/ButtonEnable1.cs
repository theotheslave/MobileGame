using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEnable1 : MonoBehaviour
{   
    public GameObject button;
    public GameObject pickable;
    void Start()
    {

    }

    private void Update()
    {
        if (pickable == null)
        {
            button.SetActive(false);
            Debug.Log("Destroyed");
        }
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Player")
        {
            button.SetActive(true);
        }

    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.name == "Player")
        {
            button.SetActive(false);
        }
    }
}
