using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Transform player;
    public float lossYThreshold = -10f;
    public Text gameOverText;
    public Text winText;

    private bool hasLost = false;
    private bool hasWon = false;

    void Start()
    {
        gameOverText.gameObject.SetActive(false);
        winText.gameObject.SetActive(false);
    }

    void Update()
    {
        CheckGameOverConditions();
        HandleRetryInput();
    }

    private void CheckGameOverConditions()
    {
        if (player.position.y < lossYThreshold && !hasLost && !hasWon)
        {
            TriggerLoss();
        }
    }

    private void HandleRetryInput()
    {
        if ((hasLost || hasWon) && Input.GetKeyDown(KeyCode.R))
        {
            Retry();
        }
    }

    private void TriggerLoss()
    {
        hasLost = true;
        gameOverText.text = "Game Over! Press 'R' to Retry";
        gameOverText.gameObject.SetActive(true);
    }

    public void TriggerWin()
    {
        hasWon = true;
        winText.text = "You Win! Press 'R' to Play Again";
        winText.gameObject.SetActive(true);
    }

    private void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
