using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovment : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private float cameraSpeed = 3f;
    [SerializeField] private float rotationSpeed = 5f;
    
    float maxCameraDistance = 6f;
    float minCameraDistance = 1f;
    float heightCamera = 2f;

    private Vector3 offset;
    private Vector3 targetPosition;
    private float currentRotationAngle;
    private float targetRotationAngle;


    void Start()
    {
        offset = transform.position - playerTransform.position;
        offset.y = heightCamera;
        currentRotationAngle = transform.eulerAngles.y;

    }

    private void LateUpdate()
    {
        UpdateCameraRotation();
        UpdateCameraPosition();
    }

    private void UpdateCameraRotation()
    {
        targetRotationAngle = playerTransform.eulerAngles.y;
        currentRotationAngle = transform.eulerAngles.y;
        float angleRotation = Mathf.DeltaAngle(currentRotationAngle, targetRotationAngle);

        if (Mathf.Abs(angleRotation) > 0.1f)
        {
            transform.RotateAround(playerTransform.position, Vector3.up, angleRotation * rotationSpeed * Time.deltaTime);
            
            Quaternion rotation = Quaternion.Euler(0, angleRotation * rotationSpeed * Time.deltaTime, 0);
            offset = rotation * offset;
            offset.y = heightCamera;

        }

    }

    private void UpdateCameraPosition()
    {
        targetPosition = playerTransform.position + offset;

        transform.position = Vector3.Lerp(transform.position, targetPosition, cameraSpeed * Time.deltaTime);


    }


}
