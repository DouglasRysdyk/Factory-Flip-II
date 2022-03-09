using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform_Position : MonoBehaviour
{
    //By default the player is set to move up towards the ceiling.  
    private bool moveUpOnJump = true; 

//    protected float delayTimer; 

    private Rigidbody2D _rigidbody; 
    
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space) && moveUpOnJump == true)
        {
//            _rigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
//            _rigidbody.gravityScale = -playerGravity;
            moveUpOnJump = false; 
        } 
        else if ((Input.GetKeyDown(KeyCode.Space)) && moveUpOnJump == false)
        {
//            _rigidbody.AddForce(new Vector2(0, -jumpForce), ForceMode2D.Impulse);
//            _rigidbody.gravityScale = playerGravity;
            moveUpOnJump = true; 
        }
    }
}

/* NOTES:
    transform.position = new Vector2 (8f, transform.position.y); 
- Does not require rigidbody, so no physics.  
- In this first example the object will move to the new position instantly.  To get it to move every frame instead of instantly...
    transform.position = new Vector2 (transform.position.x + .1f, transform.position.y); 
- This takes the current X coordinate and adds it to a value.  

- If you are using this for movement then use Time.deltaTime and FixedUpdate.  Both smooth out the movement.  
- Time.deltaTime makes every movement framerate independent.  
- FixedUpdate calls the method even if the loading of the next frame is delayed.  

From -- https://www.youtube.com/watch?v=pwRywYmajsY
*/
