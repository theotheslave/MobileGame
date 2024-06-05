using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour
{
    public float speed;
    public float timer;
    private float  randomTimer;
    // Start is called before the first frame update
    void Start()
    {
        randomTimer = Random.Range(5f, 7f);
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
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
}
