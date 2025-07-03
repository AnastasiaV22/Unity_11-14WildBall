 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovment : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;

    private Vector3 offset;
    private float smoothSpeed = 3f;
    private float distance;
    float r;
    float heightCamera = 4f;


    void Start()
    {
        distance = Vector3.Distance(transform.position, playerTransform.position);
        r = Mathf.Sqrt( Mathf.Pow(distance, 2) * Mathf.Pow(heightCamera, 2));
        offset = new Vector3(transform.position.x - playerTransform.position.x, heightCamera, transform.position.z - playerTransform.position.z);
    }

    private void FixedUpdate()
    {

        //if (transform.rotation.y + 90 != playerTransform.rotation.y)
        //{
        //    float teta = Mathf.Atan(transform.position.y / transform.position.x);
        //    float alpha = playerTransform.rotation.y - transform.rotation.y - 90;

        //    transform.position = new Vector3(r * Mathf.Cos(teta + alpha), r * Mathf.Sin(teta * alpha), 0);
        //}
        ////transform.position = new Vector3(playerTransform.position.x + offset.x, offset.y, playerTransform.position.z + offset.z);       

        Vector3 targetPosition = new Vector3(playerTransform.position.x + offset.x, heightCamera, playerTransform.position.z + offset.z);
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothSpeed * Time.fixedDeltaTime);
        
        transform.LookAt(new Vector3(30f, playerTransform.position.y, playerTransform.position.z));
    }
}
