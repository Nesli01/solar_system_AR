using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetMove : MonoBehaviour
{
    public float rotationSpeed = 100f;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                float rotationX = touch.deltaPosition.y * rotationSpeed * Time.deltaTime;
                float rotationY = -touch.deltaPosition.x * rotationSpeed * Time.deltaTime;

                transform.Rotate(rotationX, rotationY, 0, Space.World);
            }
        }
    }
}
