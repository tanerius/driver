using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool isPlayer1; // Is Player 1
    public Rigidbody2D rb; // Rb
    private float movement; // Movement

    private float speed; // Speed
    private float increment;

    private float timePassed = 0;


    // Update is called once per frame
    void Update()
    {
        if (isPlayer1)
        {
            movement = Input.GetAxisRaw("Vertical1");
        }
        else
        {
            movement = Input.GetAxisRaw("Vertical2");
        }

        timePassed = timePassed + Time.deltaTime;
        if (timePassed >= 3f)
        {
            speed = speed + increment;
            timePassed = 0;
        }

        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }

    public void SetSpeeds(float _speed, float _increment)
    {
        speed = _speed;
        increment = _increment;
    }
}
