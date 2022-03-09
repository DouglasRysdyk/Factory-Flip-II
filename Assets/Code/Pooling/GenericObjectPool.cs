using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GenericObjectPool<T> : MonoBehaviour where T : Component 
{
    [SerializeField]
    private T prefab; 

    public static GenericObjectPool<T> Instance { get; private set; }
    private Queue<T> objects = new Queue<T>();

    private void Awake() 
    {
        Instance = this;  
    }

    public T Get() 
    {
        if (objects.Count == 0)
        {
            //Can possibly optimize this later to reload obstacles.  This takes up memory though, so I need to know how many I want to preload first.  This will likely take playtesting.  
            AddObjects(1);
        }

        return objects.Dequeue(); 
    }
    
    private void AddObjects(int count) 
    {
        var newObject = GameObject.Instantiate(prefab);
        newObject.gameObject.SetActive(false); 
        objects.Enqueue(newObject);
    }

    public void ReturnToPool (T objectToReturn) 
    {
        objectToReturn.gameObject.SetActive(false);
        objects.Enqueue(objectToReturn);
    }
}
