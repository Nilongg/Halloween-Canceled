using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    float HorizontalMove;
    float VerticalMove;
    Rigidbody playerRb;
    float speed = 1;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        HorizontalMove = Input.GetAxis("Horizontal");
        VerticalMove = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(VerticalMove, 0, HorizontalMove);

        playerRb.AddForce(move * speed, ForceMode.Impulse);
    }


}
