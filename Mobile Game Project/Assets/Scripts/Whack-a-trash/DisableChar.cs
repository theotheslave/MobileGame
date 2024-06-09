using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableChar : MonoBehaviour
{
    public bool isEnter;
    public GameObject camera1;
    public GameObject camera2;
    Rigidbody m_Rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        isEnter = false;
    }

   

    // Update is called once per frame
    void Update()
    {
        if (camera2.activeInHierarchy)
        {
            isEnter = true;
        }
        else if (camera1.activeInHierarchy)
        {
            isEnter = false;
        }
        
        
        if (isEnter == true)
        {
            m_Rigidbody.constraints = RigidbodyConstraints.FreezePosition;
        }
        else
        {
            m_Rigidbody.constraints = RigidbodyConstraints.None;
        }
    }
}
