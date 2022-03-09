using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawnerScript : MonoBehaviour
{
    private float spawnRate;
    private float spawnTimer = 0; 

    void Awake() 
    {
        spawnRate = Random.Range(0, 3);
    }

    void Update()
    {
//        print("spawnRate " + spawnRate);

        spawnTimer += Time.deltaTime;

        if (spawnTimer >= spawnRate) 
            spawnRate = Random.Range(0, 3);
            spawnTimer = 0; 
            Spawn(); 
    }

    private void Spawn() 
    {
        var obstacle = ObstaclePoolScript.Instance.Get(); 
        obstacle.transform.rotation = transform.rotation;
        obstacle.transform.position = transform.position;
        obstacle.gameObject.SetActive(true);
    }
}


