using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Vector3 offset = new Vector3(0f, 1f, -2f); //Distance of camera position to player 
    private float smoothTime = 0.25f;
    private Vector3 velocity = Vector3.zero;

    [SerializeField] private Transform target;
    [SerializeField] private Vector3 rotationEulerAngles = new Vector3(20f, 0f, 0f); // Rotation for the camera

    void Start()
    {
        // Set the camera rotation using Euler angles
        transform.rotation = Quaternion.Euler(rotationEulerAngles);
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
