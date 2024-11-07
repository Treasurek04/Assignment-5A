using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static bool gameOver;
    public static bool won;

    public Text scoreText;
    private int score;

    void Start()
    {
        gameOver = false;
        score = 0;

        UpdateScore();
    }

    public void AddScore(int points)
    {
        if (!gameOver)
        {
            score += points;
            UpdateScore();
        }
    }

    private void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }   

    
}
