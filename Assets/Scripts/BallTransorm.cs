using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTransorm : MonoBehaviour
{
    public float speed = 5f; // Скорость движения мяча
    public float jumpForce = 10f; // Сила прыжка мяча
    private Rigidbody2D rb; 
    private bool isGrounded;
    private bool isEnded;
   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        
        rb.velocity = new Vector2(speed * horizontalInput, rb.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }
    void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
        if (collision.gameObject.CompareTag("Finish"))
        {
            isEnded = true;
            FindObjectOfType<GameOver>().EndGame();
        }
    }
   
}
