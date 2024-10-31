using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _playerRB;
    // Start is called before the first frame update
    void Start()
    {
        int jumpforce = 100;
        _playerRB = GetComponent<Rigidbody>();
        _playerRB.AddForce(Vector3.up * Time.deltaTime * jumpforce);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
