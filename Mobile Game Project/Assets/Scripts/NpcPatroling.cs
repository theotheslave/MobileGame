using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcPatroling : MonoBehaviour
{
    public float mvmspeed; 
    public float rotatespd;


    private bool isWandering = false;
    private bool isRotatingLeft = false;
    private bool isRotatingRight = false;
    private bool isWalking = false;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isWandering = false)
        {

            StartCoroutine(Wander());


        }
    }

    IEnumerator Wander()
    {

        int Rotationtime = Random.Range(1, 3);
        int rotateWait = Random.Range(1, 3);
        int rotateDirection = Random.Range(1, 2);
        int walkWait = Random.Range(1, 3);
        int 



    }
}
