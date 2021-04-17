using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astroids : MonoBehaviour
{
   // public Rigidbody rb;
    public ObjectPooler objectPool;
    public void Start()
    {
        objectPool = FindObjectOfType<ObjectPooler>();
        /*
        Vector3 force = Random.onUnitSphere ;
        GetComponent<Rigidbody>().velocity = force;
        */
    }
    public void OnDisable()
    {
        if(objectPool!=null)
        {
            objectPool.ReturnAstroid(this.gameObject);
        }
    }

}
