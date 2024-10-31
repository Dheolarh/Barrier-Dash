using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 spawnpos;
    private float offset;
    // Start is called before the first frame update
    void Start()
    {
        spawnpos = new Vector3(46.55f, 9.5f, 4);
        transform.position = spawnpos;
        offset = GetComponent<BoxCollider>().size.x / 2;
        Debug.Log(offset);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < spawnpos.x - offset)
        {
            transform.position = spawnpos;
        }
    }
}
