 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovment : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;

    private Vector3 offset;
    private Vector3 targetPosition;

    float heightCamera = 4f;


    void Start()
    {
        offset = new Vector3(transform.position.x - playerTransform.position.x, heightCamera, transform.position.z - playerTransform.position.z);
    }

    private void FixedUpdate()
    {
    
        transform.position = new Vector3()
      //transform.position = new Vector3(playerTransform.position.x + offset.x, offset.y, playerTransform.position.z + offset.z);       
        transform.LookAt(new Vector3(30f, playerTransform.position.y, playerTransform.position.z));

    }
}
