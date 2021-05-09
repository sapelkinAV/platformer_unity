using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 10f;

    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var rigidBody2D = GetComponent<Rigidbody2D>();
        rigidBody2D.velocity = new Vector2(horizontal * speed, rigidBody2D.velocity.y);
        Debug.Log($"Velocity = {rigidBody2D.velocity}");
        
        
    }
}
