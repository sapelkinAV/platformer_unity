using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var rigidBody2D = GetComponent<Rigidbody2D>();
        rigidBody2D.velocity = new Vector2(horizontal, rigidBody2D.velocity.y);
        Debug.Log($"Velocity = {rigidBody2D.velocity}");
        
    }
}
