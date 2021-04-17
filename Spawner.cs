using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
   
    private ObjectPooler objectPool;
    [SerializeField]
    private float timeToSpawn = 5f;
    private float timeSinceSpawn;
    // public GameObject gameObject;
    void Start()
    {
        //StartCoroutine(spawn());
        objectPool = FindObjectOfType<ObjectPooler>();
    }

    void Update()
    {
        timeSinceSpawn += Time.deltaTime;
        if(timeSinceSpawn>=timeToSpawn)
        {
            GameObject gameObject = objectPool.getAstroid();
            gameObject.transform.position = this.transform.position;
            timeSinceSpawn = 0f;
        }
    }
}
