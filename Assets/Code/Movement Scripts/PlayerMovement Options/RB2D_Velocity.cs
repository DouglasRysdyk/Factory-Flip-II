using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RB2D_Velocity : MonoBehaviour
{
    //By default the player is set to move up towards the ceiling.  
    private bool moveUpOnJump = true; 

    private Rigidbody2D _rigidbody; 
    
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Space) && moveUpOnJump == true)
        {
            print("Move up");
            moveUpOnJump = false; 
        } else if ((Input.GetKeyDown(KeyCode.Space)) && moveUpOnJump == false)
        {
            print("Move down");
            moveUpOnJump = true; 
        }
    }

    void FixedUpdate()
    {
        if (moveUpOnJump == true)
        {
            _rigidbody.velocity = new Vector2 (0f, -10f); 
        } 
        else if (moveUpOnJump == false) 
        {
            _rigidbody.velocity = new Vector2 (0f, 10f); 
        }
    }
}

/* NOTES:
    _rigidbody.velocity = new Vector2 (2f, 0f); 
- FixedUpdate when working in physics.  
- Movement at a CONSTANT velocity.  
- Can use collision and physics.  
- Good when body is dynamic.  

- If you are using this for movement then use Time.deltaTime and FixedUpdate.  Both smooth out the movement.  
- Time.deltaTime makes every movement framerate independent.  
- FixedUpdate calls the method even if the loading of the next frame is delayed.  

From -- https://www.youtube.com/watch?v=pwRywYmajsY
*/
