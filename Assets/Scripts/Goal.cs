using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool isPlayer1GoalCollided;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (isPlayer1GoalCollided)
            {
                Debug.Log("Player 2 dade gol");
                GameObject.Find("GameManager").GetComponent<GameManager>().Player2Scored();
            }
            else
            {
                Debug.Log("Player 1 dade gol");
                GameObject.Find("GameManager").GetComponent<GameManager>().Player1Scored();
            }
        }
    }
}
