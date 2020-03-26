using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptForMovement : MonoBehaviour
{
    public Vector2 speed = new Vector2(5, 5);
    private Vector2 movement;
    Rigidbody2D star;

    void Start()
    {
    }

    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
        movement = new Vector2(speed.x * inputX, speed.y * inputY);
        star = GetComponent<Rigidbody2D>();
        star.velocity = movement;
        star.gravityScale = 1;
    }
}