using System;
using UnityEngine;
using UnityEngine.UIElements;

public class Ship : MonoBehaviour
{
    // Thrust support
    Rigidbody2D rb;
    float thrustForce = 100;

    // Steering Support
    const int RotationSpeed = 100;

    // Wrapping Support
    float ScreenLeft;
    float ScreenRight;
    float ScreenTop;
    float ScreenBottom;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Vector3 ScreenTopRight = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, Camera.main.nearClipPlane));
        Vector3 ScreenBottomLeft = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, Camera.main.nearClipPlane));

        ScreenLeft = ScreenBottomLeft.x;
        ScreenBottom = ScreenBottomLeft.y;    
        ScreenRight = ScreenTopRight.x;
        ScreenTop = ScreenTopRight.y;
    }

    // Update is called once per frame
    void Update()
    {
        Thrust();
        Rotate();
        ScreenWrap();
    }
    void Thrust()
    {
        if (Input.GetAxis("Thrust") != 0 )
        {
            if (rb != null)
            {
                float xVel = - Mathf.Sin(transform.eulerAngles.z * Mathf.PI / 180);
                float yVel = Mathf.Cos(transform.eulerAngles.z * Mathf.PI / 180);

                Vector2 forceVector = new Vector2 (xVel, yVel) * Time.deltaTime * thrustForce;

                rb.AddForce(forceVector);
            }

            else
            {
                Debug.Log("Add RigidBody2D component to ship");
            }
        }
    }

    void Rotate()
    {
        float rotationDirection = Input.GetAxis("Rotate");

        if (rotationDirection != 0)
        {
            transform.Rotate(new Vector3 (0, 0, RotationSpeed * rotationDirection * Time.deltaTime));
        }
    }

    void ScreenWrap()
    {

        if (transform.position.x < ScreenLeft)
        {
            Vector2 position = transform.position;
            position.x = ScreenRight;
            transform.position = position;
        }

        if (transform.position.x > ScreenRight)
        {
            Vector2 position = transform.position;
            position.x = ScreenLeft;
            transform.position = position;
        }

        if (transform.position.y < ScreenBottom)
        {
            Vector2 position = transform.position;
            position.y = ScreenTop;
            transform.position = position;  
        }

        if (transform.position.y  > ScreenTop)
        {
            Vector2 position = transform.position;
            position.y = ScreenBottom;
            transform.position = position;
        }
    }
}
