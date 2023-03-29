using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    
    private Rigidbody2D rb;
    private Animator anim;
    private Vector2 moveInput;
    private Vector2 moveAmount;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
        moveAmount = moveInput * speed;

        if (moveInput.magnitude > 0)
        {
            anim.SetBool("isWalking", true);
            anim.SetFloat("moveX", moveInput.x);
            anim.SetFloat("moveY", moveInput.y);
        }
        else
        {
            anim.SetBool("isWalking", false);
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveAmount * Time.fixedDeltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            rb.velocity = Vector2.zero;
            anim.SetBool("isWalking", false);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            moveAmount = Vector2.zero;
        }
    }
}
