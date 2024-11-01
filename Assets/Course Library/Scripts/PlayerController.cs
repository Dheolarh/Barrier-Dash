using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public ParticleSystem _explosionParticle;
    private AudioSource _soundEffects;
    public AudioClip jumpSound;
    public AudioClip crashSound;
    public ParticleSystem _dirtSplatter;
    private Rigidbody _playerRB;
    private Animator _playerAN;
    private int jumpForce = 400;
    private float gravityModifier = 1;
    private bool isGrounded = true;
    public bool isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        _playerRB = GetComponent<Rigidbody>();
        _playerAN = GetComponent<Animator>();
        Physics.gravity *= gravityModifier;
        _soundEffects = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded && !isGameOver)
        {
            _playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
            _playerAN.SetTrigger("Jump_trig");
            _dirtSplatter.Stop();
            _soundEffects.PlayOneShot(jumpSound, 1);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            if (!isGameOver)
            {
                _dirtSplatter.Play();
            }
        }        
        if (other.gameObject.CompareTag("Barrier"))
        {
            isGameOver = true;
            Debug.Log("Gameover");
            _playerAN.SetBool("Death_b", true);
            _playerAN.SetInteger("DeathType_int", 1);
            _explosionParticle.Play();
            _dirtSplatter.Stop();
            _soundEffects.PlayOneShot(crashSound, 1);
        }
    }
}
