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

    public TextMeshProUGUI CounterText;

    private float TimePassedCounter = 3.5f;

    public Ball BallScript;

    private bool IsRestart = true;

    private void Start()
    {
        CounterText.text = "3";
        ToggleText(true);
        IsRestart = true;
    }

    public void Update()
    {
        if(IsRestart == true)
        {
            TimePassedCounter = TimePassedCounter - Time.deltaTime;

            CounterText.text = Mathf.RoundToInt(TimePassedCounter).ToString();

            if (TimePassedCounter < 0)
            {
                BallScript.Launch();
                IsRestart = false;
                TimePassedCounter = 3f;
                CounterText.text = "3";
                ToggleText(false);
            }
        }
    }

    public void Player1Scored()
    {
        Score1 = Score1 + 1;
        ScoreText1.text = Score1.ToString();
        ToggleText(true);
        BallScript.ResetBall();
        IsRestart = true;
    }

    public void Player2Scored()
    {
        Score2 = Score2 + 1;
        ScoreText2.text = Score2.ToString();
        ToggleText(true);
        BallScript.ResetBall();
        IsRestart = true;
    }

    public void ToggleText(bool p)
    {
        CounterText.gameObject.SetActive(p);
        if (p == true)
        {
            CounterText.text = "3";
        }
    }


}
