using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    private Transform playerTransform = null;
 
    [Range(1, 10)]
    [SerializeField] private float smoothSpeed = 5f;

    [SerializeField] private Vector3 offset;

    [SerializeField] private Vector3 minValue, maxValue;
    
    
    
    
    private void Start()
    {
        //playerTransform = GameObject.FindGameObjectsWithTag("Player").transform;
        
    }

    
    void LateUpdate()
    {
        UpdateCamePos();
    }

    private void UpdateCamePos()
    {
        Vector3 desiredPos = playerTransform.TransformPoint(offset);
        Vector3 clampPosition = new Vector3(
            Mathf.Clamp(desiredPos.x, minValue.x, maxValue.x),
            Mathf.Clamp(desiredPos.y, minValue.y, maxValue.z),
            Mathf.Clamp(desiredPos.z, minValue.z, maxValue.z));

        Vector3 smoothPos = Vector3.Lerp(

            transform.position,
            clampPosition,
            smoothSpeed * Time.deltaTime);

        transform.position = smoothPos;
       // transform.LookAt(targetTransform);



    }
}
