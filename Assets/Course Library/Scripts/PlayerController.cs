using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _playerRB;
    public int jumpforce = 100;
    public float gravityModifier;

    // Start is called before the first frame update
    void Start()
    {
        _playerRB = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _playerRB.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
        }
    }
}
