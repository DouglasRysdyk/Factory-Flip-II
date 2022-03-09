using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightMovement : MonoBehaviour
{
    public float moveSpeed = 1f; 

    void Update()
    {
        Vector2 resetPosition = new Vector2(23, 4.8f); 
        float currentPosition = transform.position.x;

        if (currentPosition <= -23f) {
            transform.position = resetPosition; 
        }

        transform.Translate(new Vector2 (-1f, 0f) * moveSpeed * Time.deltaTime);
    }
}

//Makes the obstacle jitter:
    // void FixedUpdate()
    // {
    //     transform.Translate(new Vector2 (-1f, 0f) * moveSpeed * Time.deltaTime);
    // }
