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

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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

        if (transform.position.x < ScreenUtils.ScreenLeft)
        {
            Vector2 position = transform.position;
            position.x = ScreenUtils.ScreenRight;
            transform.position = position;
        }

        if (transform.position.x > ScreenUtils.ScreenRight)
        {
            Vector2 position = transform.position;
            position.x = ScreenUtils.ScreenLeft;
            transform.position = position;
        }

        if (transform.position.y < ScreenUtils.ScreenBottom)
        {
            Vector2 position = transform.position;
            position.y = ScreenUtils.ScreenTop;
            transform.position = position;  
        }

        if (transform.position.y  > ScreenUtils.ScreenTop)
        {
            Vector2 position = transform.position;
            position.y = ScreenUtils.ScreenBottom;
            transform.position = position;
        }
    }
}
