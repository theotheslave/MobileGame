using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextPickup : MonoBehaviour
{
    public GameObject UiObject;
    public GameObject CollectItem;
    // Start is called before the first frame update
    void Start()
    {
        UiObject.SetActive(false);
    }
     void OnTriggerEnter(Collider other)
    {
       if(other.tag=="Player")
        {
            UiObject.SetActive(true);

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerExit(Collider other)
    {
        UiObject.SetActive(false);
        
    }
}
