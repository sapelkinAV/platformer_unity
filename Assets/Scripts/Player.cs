using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] float jumpForce = 400f;
    

    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var rigidBody2D = GetComponent<Rigidbody2D>();
        

        if (Mathf.Abs(horizontal) >= 1)
        {
            rigidBody2D.velocity = new Vector2(horizontal * speed, rigidBody2D.velocity.y);
            Debug.Log($"Velocity = {rigidBody2D.velocity}");
        }
        var animator = GetComponent<Animator>();
        var walking = horizontal != 0;
        animator.SetBool("Walk", walking);

        if (horizontal != 0)
        {
            var spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.flipX = horizontal < 0; 
        }

        if (Input.GetButtonDown("Fire1"))
        {
            rigidBody2D.AddForce(Vector2.up * jumpForce);
            
        }
    }
}
