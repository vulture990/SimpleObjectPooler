using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    /*
    [System.Serializable] 
    public class Pool
    {
        public GameObject prefab;
        public int numberOfSpawned;
    }
    */
    [SerializeField]
    GameObject astreoidPrefab;
    [SerializeField]
    private int poolStartSize = 10;
    //public List<Pool> pools;
    //public Dictionary<string, Queue<GameObject>> poolDic;
    [SerializeField]
    Queue<GameObject> poolObjects;
    void Start()
    {
        poolObjects = new Queue<GameObject>();
        for (int i = 0; i <poolStartSize;i++)
        {
            GameObject astreoid = Instantiate(astreoidPrefab);
            poolObjects.Enqueue(astreoid);
            astreoid.SetActive(false);

        }
    }
    public GameObject getAstroid()
    {
        if(poolObjects.Count>0)
        {
            GameObject astroid = poolObjects.Dequeue();
            astroid.SetActive(true);
            return astroid;
        }
        else
        {
            GameObject c = Instantiate(astreoidPrefab);
            return c;
        }
    }
    public void ReturnAstroid(GameObject Astroid)
    {
        poolObjects.Enqueue(Astroid);
        Astroid.SetActive(false);
    }
}
