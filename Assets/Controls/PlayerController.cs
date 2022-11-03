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

    [SerializeField] private float disToGround = 0.4f;

    [SerializeField] private LayerMask groundMask;

    [SerializeField] private Transform groundCheck;

    [SerializeField] private float jumpCoolDown;

    private bool jumpReady = true;

    private InputManager inputManager;

    private bool grounded;

    private float xRotation;

    private const float walkSpeed = 10f;

    private const float runSpeed = 16f;

    private float gravity = -9.81f;

    private CharacterController characterController;

    private Vector3 velocity;

    private void Start()
    {
        
        inputManager = GetComponent<InputManager>();
        characterController = GetComponent<CharacterController>();

    }

    private void FixedUpdate()
    {

        OnMove();
        gravityCheck();
        OnJump();
        HandleLook();

    }

    private void OnMove()
    {

        //Jos painetaan juoksu nappia laitetaan juoksu nopeudelle jos ei niin sitten ei.
        float targetSpeed = inputManager.Run ? runSpeed : walkSpeed;
        if (inputManager.Move == Vector2.zero) targetSpeed = 0.1f;
        float MoveX = inputManager.Move.x * targetSpeed * Time.deltaTime;
        float MoveZ = inputManager.Move.y * targetSpeed * Time.deltaTime;

        Vector3 moveDirection = transform.TransformDirection(new Vector3(MoveX, 0, MoveZ));

        characterController.Move(moveDirection);

    }
    private void gravityCheck()
    {
        grounded = Physics.CheckSphere(groundCheck.position, disToGround, groundMask);

        if (grounded && velocity.y < 0)
            velocity.y = -2f;

        velocity.y += gravity * Time.deltaTime;

        characterController.Move(velocity * Time.deltaTime);
        
    }

    private void OnJump()
    {
        if (inputManager.Jump && grounded && jumpReady)
        {
            velocity.y = Mathf.Sqrt(jumpFactor * -2f * gravity);
            jumpReady = false;
            StartCoroutine(Cooldown());
        }
        
    }

    private void HandleLook()
    {
        float Mouse_X = inputManager.Look.x;
        float Mouse_Y = inputManager.Look.y;

        xRotation -= Mouse_Y * mouseSens * Time.deltaTime;
        xRotation = Mathf.Clamp(xRotation, camUpperLimit, camBottomLimit);

        cam.localRotation = Quaternion.Euler(xRotation, 0, 0);
        transform.Rotate(Vector3.up, Mouse_X * mouseSens * Time.deltaTime);
    }
    IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(jumpCoolDown);
        jumpReady = true;
    }

  
}
