using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
     
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        cam1.SetActive(true);
        cam2.SetActive(false);
        score = 0;
    }

    // Update is called once per frame
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
                    OnMouseDown(raycastHit.transform.gameObject);
                }
            }
        }
    }

    public void OnMouseDown(GameObject gameObject)
    {
        if (gameObject.tag == "bucket")
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
        }
        Debug.Log("kur");
        
    }
   


}
