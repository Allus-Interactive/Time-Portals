using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Transform cameraTransform;

    void Start()
    {
        cameraTransform = Camera.main.transform;
    }

    void Update()
    {
        if (Input.GetTouch(0).phase == TouchPhase.Moved && Input.touchCount > 0)
        {
            Vector2 TouchDirection = Input.GetTouch(0).deltaPosition;
            Vector3 worldVector = Camera.main.ScreenToWorldPoint(new Vector3(0, TouchDirection.y, 0));
            transform.RotateAround(player.transform.position, (new Vector3(0.0f, worldVector.y, 0.0f)), TouchDirection.x * 0.37f);

            cameraTransform.LookAt(transform.position + transform.forward * 10f);
        }
    }
}
