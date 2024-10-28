using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private int score;
    private GameManager gameManager;

    void Start()
    {
        score = 0;
        UpdateScoreUI();
        gameManager = FindObjectOfType<GameManager>();
    }

    public void AddScore(int points)
    {
        score += points;
        UpdateScoreUI();

        if (score == 10)
        {
            gameManager.TriggerWin();
        }
    }

    public void ResetScore()
    {
        score = 0;
        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
        scoreText.text = "Score: " + score;
    }
}
