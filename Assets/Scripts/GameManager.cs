using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI WinnerText;

    public GameObject Meni;

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

    private bool IsGameRunning = false;

    private void Start()
    {
        IsGameRunning = false;
        Meni.SetActive(true);

        CounterText.text = "3";
        ToggleText(true);
        IsRestart = true;

    }

    public void Update()
    {
        if (IsGameRunning == false)
            return;

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
        AnyoneScored();
    }

    public void Player2Scored()
    {
        Score2 = Score2 + 1;
        ScoreText2.text = Score2.ToString();
        ToggleText(true);
        BallScript.ResetBall();
        IsRestart = true;
        AnyoneScored();
    }

    private void AnyoneScored()
    {
        if(Score1 == 3)
        {
            // Da se ispise tekst sto ke ni kaze deka Player 1 pobedil
            WinnerText.text = "Player 1 is the winner!";

            // Da zavrsi igrata
            // i da se resetira score
            StopGame();
        }

        if (Score2 == 3)
        {
            // Da se ispise tekst sto ke ni kaze deka Player 2 pobedil
            WinnerText.text = "Player 2 is the winner!";

            // Da zavrsi igrata
            // i da se resetira score
            StopGame();
        }

    }

    public void ToggleText(bool p)
    {
        CounterText.gameObject.SetActive(p);
        if (p == true)
        {
            CounterText.text = "3";
        }
    }

    public void StartGame()
    {
        Meni.SetActive(false);
        IsGameRunning = true;

        // Da se izbrise tekstot (koj pobedil) od minatata igra 
        WinnerText.text = "";
    }

    public void StopGame()
    {
        // Prekini ja igrata
        IsGameRunning = false;

        // Prikazi go menito
        Meni.SetActive(true);

        // Donesi ja topkata vo sredina
        BallScript.ResetBall();

        // Resetiraj go brojcanikot da pocne da broi povtorno od 3
        TimePassedCounter = 3f;

        // Setiraj go tekstot da bide ednakov na 3
        CounterText.text = "3";

        // Prikazi go brojcanikot
        ToggleText(true);

        // Resetirame rezultatite
        Score1 = 0;
        Score2 = 0;
        ScoreText1.text = Score1.ToString();
        ScoreText2.text = Score2.ToString();
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadTestScene()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}
