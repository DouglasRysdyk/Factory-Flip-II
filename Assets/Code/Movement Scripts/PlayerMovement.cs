using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Code copied from -- https://www.youtube.com/watch?v=n4N9VEA2GFo 

public class PlayerMovement : MonoBehaviour
{
    //By default the player is set to move up towards the ceiling.  
    private bool moveUpOnJump = true; 

    private Rigidbody2D rb2D; 

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && moveUpOnJump == true)
        {
//            print("Move up"); 
            moveUpOnJump = false; 
            Physics2D.gravity = Physics2D.gravity * -1; 
//            print("Physics2D.gravity " + Physics2D.gravity);
        } 
        else if ((Input.GetKeyDown(KeyCode.Space)) && moveUpOnJump == false)
        {
//            print("Move down"); 
            moveUpOnJump = true; 
            Physics2D.gravity = Physics2D.gravity * -1; 
//            print("Physics2D.gravity " + Physics2D.gravity);
        }
    }

    void FixedUpdate()
    { 
        //Go up 
        if (moveUpOnJump == true)
            rb2D.AddForce(new Vector2(0f, -55f) * Time.deltaTime, ForceMode2D.Impulse); 
        //Go down 
        else if (moveUpOnJump == false)
            rb2D.AddForce(new Vector2(0f, 55f) * Time.deltaTime, ForceMode2D.Impulse); 
    }
}
/*
{
    //By default the player is set to move up towards the ceiling.  
    private bool moveUpOnJump = true; 
    private float jumpForce = 3; 
    private float playerGravity = 0f;
    private float delayAmount = .1f; 

    protected float delayTimer; 

    private Rigidbody2D _rigidbody; 
    
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        delayTimer += Time.deltaTime; 

        if (Input.GetKeyDown(KeyCode.Space) && moveUpOnJump == true)
        {
            incrementGravity();

            _rigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            _rigidbody.gravityScale = -playerGravity;
            moveUpOnJump = false; 
        } 
        else if ((Input.GetKeyDown(KeyCode.Space)) && moveUpOnJump == false)
        {
            incrementGravity();

            _rigidbody.AddForce(new Vector2(0, -jumpForce), ForceMode2D.Impulse);
            _rigidbody.gravityScale = playerGravity;
            moveUpOnJump = true; 
        }
    }

    void incrementGravity() {
        playerGravity = 0f;

        if (delayTimer >= delayAmount) 
        {
            delayTimer = 0f;

            playerGravity = 3f; 
        }
    }
}
*/


