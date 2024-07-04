using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour
{
    public float speed;
    public float timer;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
<<<<<<< HEAD
        transform.Translate(1 * speed * Time.deltaTime, 0,0 );
        
        if(timer == randomTimer)
        {

            speed = 10f;

        }


        void OnTriggerEnter(Collider collision)
        {
            if (collision.gameObject.tag == ("wall"))
            {
                Destroy(gameObject);
                Debug.Log("Cool");
            }
        }
        }
=======
        transform.Translate(1 * speed * Time.deltaTime,0,0 );
        
    }
>>>>>>> Teo-from-menas
}
