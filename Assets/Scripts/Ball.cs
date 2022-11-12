using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;

    
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
    }

    public void ResetBall()
    {
        rb.velocity = Vector2.zero;
        rb.position = Vector2.zero;
    }
}
