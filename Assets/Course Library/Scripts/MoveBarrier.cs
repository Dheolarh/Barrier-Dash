using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBarrier : MonoBehaviour
{
    private PlayerController _playerScript;
    private float barrierSpeed = 8f;
    private float xRange = 12.5f;
    // Start is called before the first frame update
    void Start()
    {
        _playerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_playerScript.isGameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * barrierSpeed);
        }

        if (transform.position.x < -xRange && gameObject.CompareTag("Barrier"))
        {
            Destroy(gameObject);
        }
            
    }
    
    
}
