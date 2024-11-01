using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject barrierPrefab;
    private Vector3 spawnPoint = new Vector3(21.3f, 0, 0);
    public float xRange = 3.0f;
    private PlayerController _playerScript;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBarrier",2,2); 
        _playerScript = GameObject.Find("Player").GetComponent<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnBarrier()
    {
        if (_playerScript.isGameOver == false)
        {
            Instantiate(barrierPrefab, spawnPoint, barrierPrefab.transform.rotation);
        }
    }
}
