using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwap2 : MonoBehaviour
{

    public GameObject player;
    public GameObject cam1;
    public GameObject cam2;
    public GameObject UI;
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
            UI.SetActive(false);
        }
    }
}