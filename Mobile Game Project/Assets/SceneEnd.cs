using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneEnd : MonoBehaviour
{
    // Start is called before the first frame update
void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.name == "Player")
        {

            SceneManager.LoadScene("EndScene");

        }


    }
}
