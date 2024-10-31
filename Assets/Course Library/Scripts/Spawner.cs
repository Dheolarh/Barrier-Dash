using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject barrierPrefab;
    private Vector3 spawnPoint = new Vector3(8.3f, 0, 0);
    public float xRange = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBarrier",2,2);    
    }

    // Update is called once per frame
    void Update()
    {
       SpawnBarrier(); 
    }

    void SpawnBarrier()
    {
        Instantiate(barrierPrefab, spawnPoint, barrierPrefab.transform.rotation);
    }
}
