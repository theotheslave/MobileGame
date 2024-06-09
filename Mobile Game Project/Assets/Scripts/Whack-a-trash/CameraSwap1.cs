using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwap1 : MonoBehaviour
{

    public GameObject player;
    public GameObject cam1;
    public GameObject cam2;

    void Start()
    {

    }


    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Player")
        {
            player.SetActive(false);
            cam1.SetActive(false);
            cam2.SetActive(true);
        }
    }
}
