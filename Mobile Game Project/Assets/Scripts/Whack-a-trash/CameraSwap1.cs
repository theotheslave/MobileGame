using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwap1 : MonoBehaviour
{
<<<<<<< HEAD
    public GameObject cam1;
    public GameObject cam2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.name == "Player")
        {
=======

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
>>>>>>> Teo-from-menas
            cam1.SetActive(false);
            cam2.SetActive(true);
        }
    }
}
