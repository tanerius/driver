using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private float speed;
    private float increment;

    private float timePassed = 0f;
    public Rigidbody2D rb;
    private bool isBallMoving = false;

    
    public void Launch()
    {
        float x = 0;
        int privremenBroj = Random.Range(0, 2);
        if (privremenBroj == 0)
        {
            x = -1;
        }
        else
        {
            x = 1;
        }

        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);
        isBallMoving = true;
        rb.freezeRotation = false;
    }

    public void ResetBall()
    {
        isBallMoving = false;
        rb.velocity = Vector2.zero;
        rb.position = Vector2.zero;
        timePassed = 0;
        rb.rotation = 0;
        rb.freezeRotation = true;
    }

    public void SetSpeeds(float _speed, float _increment)
    {
        speed = _speed;
        increment = _increment;
    }

    private void Update()
    {
        if (isBallMoving == true)
        {
            timePassed = timePassed + Time.deltaTime;
            if(timePassed >= 3f)
            {
                speed = speed + increment;
                timePassed = 0;
            }
            // 1 = za pozitiven broj
            // 0 = za negativen broj
            float x = Mathf.Sign(rb.velocity.x);
            float y = Mathf.Sign(rb.velocity.y);
            rb.velocity = new Vector2(speed * x, speed * y);
        }
    }
}
