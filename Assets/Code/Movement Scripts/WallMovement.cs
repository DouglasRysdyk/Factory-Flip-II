using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovement : MonoBehaviour
{
    public float moveSpeed = 1f; 

    // Update is called once per frame
    void Update() 
    {
        Vector2 resetPosition = new Vector2(30, 1); 
        float currentPosition = transform.position.x;

        if (currentPosition <= -28) {
            transform.position = resetPosition; 
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(new Vector2 (-1f, 0f) * moveSpeed * Time.deltaTime);
    }
}


