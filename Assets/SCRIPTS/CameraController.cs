using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public float movementSpeed;

    public float minDistance;
    public float maxDistance;
    public float zoomSpeed;

    void Update()
    {

        GetComponent<Camera>().orthographicSize = Mathf.Clamp(GetComponent<Camera>().orthographicSize - Input.GetAxis("Mouse ScrollWheel") * zoomSpeed, minDistance, maxDistance);

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(movementSpeed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-movementSpeed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, -movementSpeed * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, movementSpeed * Time.deltaTime, 0));
        }
    }

    private void LateUpdate()
    {
        if (transform.position.x > 8)
            transform.position = new Vector3(8, transform.position.y, -10);
        if (transform.position.x < -8)
            transform.position = new Vector3(-8, transform.position.y, -10);
        if (transform.position.y > 10)
            transform.position = new Vector3(transform.position.x, 10, -10);
        if (transform.position.y < -10)
            transform.position = new Vector3(transform.position.x, -10, -10);
    }

}
