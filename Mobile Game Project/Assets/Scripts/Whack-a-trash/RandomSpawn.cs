using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour { 
    public GameObject[] spawnee;
    public GameObject trash;
    public bool stopSpawning = false;
    public float spawnDelay;
    public float spawnTime;
    public int score;
    public GameObject camera1;
    public GameObject camera2;

    public Camera lakeCamera;
        // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnDelay, spawnTime);
        score = 0;
        
    }

    void StartSpawning()
    {
        
      
        
        

        if (score >= 10)
        {
            Invoke("SpawnBucket", spawnDelay);
            
        }
        
    }

    // Update is called once per frame
    void SpawnObject()
    {

        int randomIndex = Random.Range(0, spawnee.Length);
        Vector3 randomSpawnPosition = new Vector3(-9, 2,Random.Range(-9, 0));
        Instantiate(spawnee[randomIndex], randomSpawnPosition, Quaternion.identity);
        if (stopSpawning == true)
        {
            CancelInvoke("SpawnObject");
        }
    }
    
    
    void SpawnBucket()
    {

        int randomIndex = Random.Range(0, spawnee.Length);
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-3, 3), 2,-14);
        Instantiate(spawnee[randomIndex], randomSpawnPosition, Quaternion.identity);
        if (stopSpawning == true)
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
            Ray ray = Camera.current.ScreenPointToRay(Input.mousePosition);
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

        if (gameObject.tag == "bucket")
        {
            stopSpawning = true;
            camera1.SetActive(true);
            camera2.SetActive(false);

        }
        
    }
}
