using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObstacleCollision : MonoBehaviour
{
    public PlayerMovement movement; 

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
//            movement.enabled = false;
//            print("You should be dead");
        }
    } 
/*
    //Alternate method, but doesn't disable physics so the objects still hit one another.  
    private void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
//            movement.enabled = false;
            print("You should be dead.");
        }
    }
*/
}


