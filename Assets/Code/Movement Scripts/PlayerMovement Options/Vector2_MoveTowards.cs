using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector2_MoveTowards : MonoBehaviour
{
    //By default the player is set to move up towards the ceiling.  
    private bool moveUpOnJump = true; 
    public float playerSpeed = 0f; 
    public float speedMultiple = 0f;

    private Rigidbody2D _rigidbody; 
    
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Space) && moveUpOnJump == true)
        {
            //Reset the player speed 
            //I really don't like this because it's hard coded.  If I change the public var this doesn't change.  
            playerSpeed = 10;
            moveUpOnJump = false; 
        } else if ((Input.GetKeyDown(KeyCode.Space)) && moveUpOnJump == false)
        {
            //Reset the player speed 
            //I really don't like this because it's hard coded.  If I change the public var this doesn't change.  
            playerSpeed = 10;
            moveUpOnJump = true; 
        }
    }

    void FixedUpdate()
    {
        if (moveUpOnJump == true)
        {
            //I don't like how this the Y position is hard coded.  If I change the floor and ceiling location then I need to change this.  
            transform.position = Vector2.MoveTowards (transform.position, new Vector2 (transform.position.x, -2f), addSpeed() * Time.deltaTime);
        } 
        else if (moveUpOnJump == false) 
        {
            //I don't like how this the Y position is hard coded.  If I change the floor and ceiling location then I need to change this.  
            transform.position = Vector2.MoveTowards (transform.position, new Vector2 (transform.position.x, 4f), addSpeed() * Time.deltaTime);
        }
    }

    float addSpeed() {
        float speedTime = Time.deltaTime; 

        playerSpeed += speedTime * speedMultiple; 

        if (playerSpeed >= 100) {
            playerSpeed = 100;
        }

        return playerSpeed; 
    }
}

/* NOTES:
    transform.position = Vector2.MoveTowards (transform.position, new Vector2 (8f, transform.position.y), 1f * Time.deltaTime); 
- Two vector values + a speed value.  
- Object will move from start position to the end position with the speed value specified in the script.  
- Can add a rigidbody for physics.  

- If you are using this for movement then use Time.deltaTime and FixedUpdate.  Both smooth out the movement.  
- Time.deltaTime makes every movement framerate independent.  
- FixedUpdate calls the method even if the loading of the next frame is delayed.  

From -- https://www.youtube.com/watch?v=pwRywYmajsY
*/
