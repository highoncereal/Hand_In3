using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerMovement : MonoBehaviour
{
    private Vector2 movement;
    private Rigidbody2D myBody;
    private Animator myAnimator;

    [SerializeField] private int speed = 5;

    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
    }

    private void OnMovement(InputValue value)
    {
        movement = value.Get<Vector2>();

        if (movement.x != 0 || movement.y != 0)
        {
            myAnimator.SetBool("IsWalking", true);
        }

        else
        {
            myAnimator.SetBool("IsWalking", false);
        }
    }

    private void FixedUpdate()
    {
        myBody.velocity = movement * speed;
    }
}
