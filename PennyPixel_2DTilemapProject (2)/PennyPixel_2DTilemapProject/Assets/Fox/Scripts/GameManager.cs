/*
 * Treasure Keys
 * Assignment 5A
 * Manage the Score UI and point system
 * Win and lose manager for the game
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Transform player;
    public float lossYThreshold = -10f;
    public Text loseText;
    private bool hasLost = false;
   

    void Start()
    {
        loseText.gameObject.SetActive(false);
    }

    void Update()
    {
        CheckGameOverConditions();
        HandleRetryInput();
    }

    private void CheckGameOverConditions()
    {
        if (player.position.y < lossYThreshold && !hasLost)
        {
            TriggerLoss();
        }
    }

    private void HandleRetryInput()
    {
        if (hasLost && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void TriggerLoss()
    {
        loseText.text = "Game Over! Press 'R' to Retry";
        loseText.gameObject.SetActive(true);
        hasLost = true;
    }

    
}
