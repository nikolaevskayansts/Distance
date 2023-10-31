using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float speed;
    private Vector2 movement;
    private Rigidbody2D rb;
    private Camera camera;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        camera = GetComponent<Camera>();
    }

    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");


            movement = new Vector2(speed * inputX, speed * inputY);
        

            if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            camera.orthographicSize = camera.orthographicSize + 1f;
            if (camera.orthographicSize > 15)
            {
                    camera.orthographicSize = 15;
            }
        }

        if (Input.GetAxis("Mouse ScrollWheel") > 0f) 
        {
            camera.orthographicSize = camera.orthographicSize - 1f;
            if (camera.orthographicSize < 5)
            {
                camera.orthographicSize = 5; 
            }
        }
    }

    void FixedUpdate()
    {
        rb.velocity = movement;
        

    }
}
