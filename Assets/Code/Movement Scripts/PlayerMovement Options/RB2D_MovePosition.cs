using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RB2D_MovePosition : MonoBehaviour
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
            _rigidbody.MovePosition(_rigidbody.position + new Vector2 (0f, -10f) * Time.deltaTime);
        } 
        else if (moveUpOnJump == false) 
        {
            _rigidbody.MovePosition(_rigidbody.position + new Vector2 (0f, 10f) * Time.deltaTime);
        }
    }
}

/* NOTES:
    _rigidbody.MovePosition(_rigidbody.position + new Vector2 (1f, 0f) * Time.deltaTime);
- Velocity is calculated under the hood(?). 
- Take current position then add a vector.  The object will move to that positon every frame.  
- Works best for kinematic body, unlike .velocity.  

- If you are using this for movement then use Time.deltaTime and FixedUpdate.  Both smooth out the movement.  
- Time.deltaTime makes every movement framerate independent.  
- FixedUpdate calls the method even if the loading of the next frame is delayed.  

From -- https://www.youtube.com/watch?v=pwRywYmajsY
*/
