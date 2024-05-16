using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour { 
    public GameObject[] spawnee;
    public bool stopSpawning = false;
    public float spawnDelay;
    public float spawnTime;
    public int score;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
        score = 0;
    }

    // Update is called once per frame
    void SpawnObject()
    {

        int randomIndex = Random.Range(0, spawnee.Length);
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-3, 3), 2,-14);
        Instantiate(spawnee[randomIndex], randomSpawnPosition, Quaternion.identity);
        if (stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }


    void Update()
    {
        //Check for mouse click 
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit raycastHit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out raycastHit, 100f))
            {
                if (raycastHit.transform != null)
                {
                    //Our custom method. 
                    CurrentClickedGameObject(raycastHit.transform.gameObject);
                }
            }
        }
    }


    public void CurrentClickedGameObject(GameObject gameObject)
    {
        if (gameObject.tag == "trash")
        {
            
            Debug.Log(score++);
        }
        if (score == 10)
        {
         
            stopSpawning = true;
        }
    }
}
