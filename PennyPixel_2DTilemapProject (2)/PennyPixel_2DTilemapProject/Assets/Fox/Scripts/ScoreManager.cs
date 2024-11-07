/*
 * Treasure Keys
 * Assignment 5A
 * Manage the Score UI and point system
 
 */

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
    public Text winText;
    private int score;
    private GemCollision gemCollision;

    void Start()
    {
        gameOver = false;
        won = false;
        score = 0;

        winText.gameObject.SetActive(false);
        UpdateScore(); 
    }

    public void AddScore(int points)
    {
        if (!gameOver)
        {
            score += points;
            UpdateScore();
        }

        if (score >= 10)
        {
            GameOver(true);
            winText.text = "You Win! Press 'R' to Play Again";
            winText.gameObject.SetActive(true);
        }
    }

    private void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }

    void GameOver(bool result)
    {
        won = result;
        gameOver = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
