using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;

    public GameObject Goal1;
    public GameObject Goal2;

    public GameObject Ball;

    public int Score1 = 0;
    public int Score2 = 0;

    public TextMeshProUGUI ScoreText1;
    public TextMeshProUGUI ScoreText2;

    public void Player1Scored()
    {
        Score1 = Score1 + 1;
        ScoreText1.text = Score1.ToString();
    }

    public void Player2Scored()
    {
        Score2 = Score2 + 1;
        ScoreText2.text = Score2.ToString();
    }
}
