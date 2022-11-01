using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using inputManager.pena;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Transform cam;

    [SerializeField] private float camUpperLimit = -40f;

    [SerializeField] private float camBottomLimit = 70f;

    [SerializeField] private float mouseSens = 21f;

    [SerializeField] private float jumpFactor = 250f;

    [SerializeField] private float disToGround = 10f;

    [SerializeField] private LayerMask groundCheck;

    private Rigidbody playerRb;

    private InputManager inputManager;

    private bool grounded;

    private float xRotation;

    private const float walkSpeed = 2f;
    
    private const float runSpeed = 6f;

    private Vector2 currentVelocity;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        inputManager = GetComponent<InputManager>();
    }

    private void FixedUpdate()
    {
        
        OnMove();
        
    }

    private void OnMove()
    {
        //Jos painetaan juoksu nappia laitetaan juoksu nopeudelle jos ei niin sitten ei.
        float targetSpeed = inputManager.Run ? runSpeed : walkSpeed;
        if (inputManager.Move == Vector2.zero) targetSpeed = 0.1f;
        float MoveX = inputManager.Move.x * targetSpeed;
        float MoveZ = inputManager.Move.y * targetSpeed;

        Vector3 move = new Vector3(MoveX, 0, MoveZ);


        playerRb.AddForce(move, ForceMode.Impulse);
    }
}
