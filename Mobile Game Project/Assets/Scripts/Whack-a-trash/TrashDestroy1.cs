using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashDestroy1 : MonoBehaviour
{
    public float timer;
    [SerializeField] GameObject burstVFX;
    public void OnMouseDown()
          
    {
        Destroy(gameObject);
        GameObject explosion = Instantiate(burstVFX, transform.position, transform.rotation);


    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("wall"))
        {
            Destroy(gameObject);
            
        }


    }
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 20)
        {
            Destroy(gameObject);
        }

    }



}
