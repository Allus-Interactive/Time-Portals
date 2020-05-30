using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Transform cameraTransform;

    public float zoomMin = 30f;
    public float zoomMax = 100f;

    public float zoomSpeed = 0.5f;

    public Camera camera;

    void Start()
    {
        cameraTransform = Camera.main.transform;
        camera = GetComponent<Camera>();
    }

    void Update()
    {
        if (Input.GetTouch(0).phase == TouchPhase.Moved && Input.touchCount == 1)
        {
            Vector2 TouchDirection = Input.GetTouch(0).deltaPosition;
            Vector3 worldVector = Camera.main.ScreenToWorldPoint(new Vector3(0, TouchDirection.y, 0));
            transform.RotateAround(player.transform.position, (new Vector3(0.0f, worldVector.y, 0.0f)), TouchDirection.x * 0.37f);

            cameraTransform.LookAt(transform.position + transform.forward * 10f);
        }

        if (Input.touchCount == 2)
        {
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            float prevMagnitude = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float currentMagnitude = (touchZero.position - touchOne.position).magnitude;

            float difference = prevMagnitude - currentMagnitude;

            camera.fieldOfView += difference * zoomSpeed;
            camera.fieldOfView = Mathf.Clamp(camera.fieldOfView, zoomMin, zoomMax);
        }
    }
}
