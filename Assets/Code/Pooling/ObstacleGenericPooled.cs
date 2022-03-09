using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenericPooled : MonoBehaviour
{
    public float moveSpeed = 1f;  

    private float currentPosition;

    // void OnEnable()
    // {
    //     print("Object is disabled."); 
    // }

    private void Update()
    {
        currentPosition = transform.position.x; 

        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);

        if (currentPosition <= -12f)
            //Try changing the mesh here assuming the collision changes with it.  
            ObstaclePoolScript.Instance.ReturnToPool(this);
    }

    // void OnDisable()
    // {
    //     print("Object is disabled."); 
    // }
}

//https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnEnable.html 

/* Original Generic Pooling Code:
{
    public float moveSpeed = 30f;  

    private float lifeTime; 
    private float maxLifeTime = 5f;  

    private void Start()
    {
        lifeTime = 0f;  
    }

    private void Update()
    {
        float currentPosition = transform.position.x; 

        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        lifeTime += Time.deltaTime; 

        if (lifeTime > maxLifeTime) 
        {
            ObstaclePoolScript.Instance.ReturnToPool(this);
        }
    }
}
*/


