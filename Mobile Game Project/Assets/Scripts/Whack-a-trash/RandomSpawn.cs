using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class RandomSpawn : MonoBehaviour { 
    public GameObject[] spawnee;
<<<<<<< HEAD
    public GameObject bucket;
=======
    public GameObject trash;
>>>>>>> Teo-from-menas
    public bool stopSpawning = false;
    public float spawnDelay;
    public float spawnTime;
    public int score;
    public GameObject camera1;
    public GameObject camera2;
    public GameObject player;
    public GameObject lake;
    public GameObject lake1;
    public GameObject UI;
    public Camera MainCamera;

    public Camera Camera;
        // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("SpawnObject", spawnDelay, spawnTime);
        score = 0;
<<<<<<< HEAD
        if (score == 10)
        {
            Vector3 randomSpawnPosition = new Vector3(-9, 6, Random.Range(24, 30));
            Instantiate(bucket, randomSpawnPosition, Quaternion.identity);

            stopSpawning = true;
        }

=======
        
    }

    void StartSpawning()
    {
        
      
        
        

        if (score >= 10)
        {
            Invoke("SpawnBucket", spawnDelay);
            
        }
        
>>>>>>> Teo-from-menas
    }

    // Update is called once per frame
    void SpawnObject()
    {

        int randomIndex = Random.Range(0, spawnee.Length);
<<<<<<< HEAD
        Vector3 randomSpawnPosition = new Vector3(-9, 6, Random.Range(24, 30));
=======
        Vector3 randomSpawnPosition = new Vector3(119, 1,Random.Range(10, 20));
>>>>>>> Teo-from-menas
        Instantiate(spawnee[randomIndex], randomSpawnPosition, Quaternion.identity);
        if (stopSpawning == true)
        {
            CancelInvoke(nameof(SpawnObject));
        }
    }
    
    
    void SpawnBucket()
    {

        int randomIndex = Random.Range(0, spawnee.Length);
        Vector3 randomSpawnPosition = new Vector3(3, 1,Random.Range(40,50));
        Instantiate(trash, randomSpawnPosition, Quaternion.identity);
        if (stopSpawning == true)
        {
            CancelInvoke(nameof(SpawnObject));
        }
    }


    void Update()
    {
        if (camera2.activeInHierarchy)
        {
            Camera = Camera.main;
        }
        //Check for mouse click 
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit raycastHit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out raycastHit, 100f))
            {
                if (raycastHit.transform != null)
                {
                    //Custom method
                    CurrentClickedGameObject(raycastHit.transform.gameObject);
                }
            }
        }

      
    }


    public void CurrentClickedGameObject(GameObject destroyable)
    {
        if (destroyable.CompareTag("trash"))
        {
            
            Debug.Log(score++);
        }
<<<<<<< HEAD
       
=======

        if (score >= 10)
        {
            
            MainCamera= Camera.main;
            stopSpawning = true;
            camera1.SetActive(true);
            camera2.SetActive(false);
            player.SetActive(true);
            lake.SetActive(false);
            lake1.SetActive(true);
            trash.SetActive(true);
            Destroy(gameObject);
            UI.SetActive(true);
        }
        
>>>>>>> Teo-from-menas
    }
}
