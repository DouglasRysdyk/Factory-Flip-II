using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RB2D_AddForce : MonoBehaviour
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
        } 
        else if ((Input.GetKeyDown(KeyCode.Space)) && moveUpOnJump == false)
        {
            print("Move down");
            moveUpOnJump = true; 
        }
    }

    void FixedUpdate()
    { 
        if (moveUpOnJump == true)
        {
            _rigidbody.AddForce(new Vector2(0f, -2000f) * Time.deltaTime);//, ForceMode2D.Impulse); //Can Time.deltaTime for a slightly different effect 
        } 
        else if (moveUpOnJump == false)
        {
            _rigidbody.AddForce(new Vector2(0f, 2000f) * Time.deltaTime);//, ForceMode2D.Impulse); //Can Time.deltaTime for a slightly different effect 
        }

    }
}

/* NOTES:
    _rigidbody.AddForce(new Vector2 (100f, 0f) * Time.deltaTime); 
- Normally does not use an update function since this would add force every frame.  Thus velocity increases each frame.  Starts slow and goes quickly.  
- Cubed velocity decreases because of drag(?).    
- Object will start slow and increase in speed each frame.  

- If you are using this for movement then use Time.deltaTime and FixedUpdate.  Both smooth out the movement.  
- Time.deltaTime makes every movement framerate independent.  
- FixedUpdate calls the method even if the loading of the next frame is delayed.  

From -- https://www.youtube.com/watch?v=pwRywYmajsY
*/
