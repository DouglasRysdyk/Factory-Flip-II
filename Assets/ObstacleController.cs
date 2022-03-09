using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public bool isTop; 

    private Vector3 startPosition = new Vector3(15, -3, -1);
    private float moveSpeed = 1f; 

    [SerializeField]
    private Material obstacleMaterial; 

    private void Awake()
    {
        if (isTop == true)
            startPosition  = new Vector3(15, 5, -1);

        //Attempt to remove isTop solution.  
        // if (startPosition.y == -3)
        // {
        //     startPosition = new Vector3(15, -3, -1);
        // } 
        // else if (startPosition.y == 5)
        // {
        //     startPosition  = new Vector3(15, 5, -1);
        // }

        moveSpeed = Random.Range(10, 30); 
    }

    private void Update()
    {
        float currentPosition = transform.position.x;

        transform.Translate(new Vector2 (-1f, 0f) * moveSpeed * Time.deltaTime);

        if (currentPosition <= -12f) 
        {
            transform.position = startPosition; 
            // obstacleMaterial.color = Color.red; //Can use this to change the color for Fruit Flip.  
            moveSpeed = Random.Range(10, 30); 
        }
    }
}

//Factory Flip: 
//Randomly select a number 
//Number corresponds to a prefab 
//Prefab contains the model, and speed 

//Fruit Flip: 
//Similar structure with the random number and prefabs etc.  
//BUT some numbers don't work with other numbers.  This is to give the player the option to survive.  
//Player can either go through an obstacle, die to an obstacle, or dodge and obstacle.  

//Makes the obstacle jitter:
    // void FixedUpdate()
    // {
    //     transform.Translate(new Vector2 (-1f, 0f) * moveSpeed * Time.deltaTime);
    // }



