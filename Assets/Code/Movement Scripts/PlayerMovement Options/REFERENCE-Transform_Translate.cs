using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform_Translate : MonoBehaviour
{
    //By default the player is set to move up towards the ceiling.  
    private bool moveUpOnJump = true; 
    private float jumpForce = 3; 
//    private float playerGravity = 0f;
//    private float delayAmount = .1f; 

//    protected float delayTimer; 

    private Rigidbody2D _rigidbody; 
    
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
//        delayTimer += Time.deltaTime; 

        if (Input.GetKeyDown(KeyCode.Space) && moveUpOnJump == true)
        {
//            incrementGravity();

            _rigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
//            _rigidbody.gravityScale = -playerGravity;
            moveUpOnJump = false; 
        } 
        else if ((Input.GetKeyDown(KeyCode.Space)) && moveUpOnJump == false)
        {
            _rigidbody.AddForce(new Vector2(0, -jumpForce), ForceMode2D.Impulse);
//            _rigidbody.gravityScale = playerGravity;
            moveUpOnJump = true; 
        }
    }
}

/* NOTES:
    transform.Translate(new Vector2 (1f, 0f) * moveSpeed * Time.deltaTime);
- Does not require rigidbody, so no physics.  
- The cube will move 1 unit on the axis we gavbe a value to (X in this case).  

- If you are using this for movement then use Time.deltaTime and FixedUpdate.  Both smooth out the movement.  
- Time.deltaTime makes every movement framerate independent.  
- FixedUpdate calls the method even if the loading of the next frame is delayed.  

From -- https://www.youtube.com/watch?v=pwRywYmajsY
*/
