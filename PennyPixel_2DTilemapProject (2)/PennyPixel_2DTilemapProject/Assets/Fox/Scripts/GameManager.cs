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
    private bool hasLost = false;

    void Start()
    {
        gameOverText.gameObject.SetActive(false);
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
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void TriggerLoss()
    {
        gameOverText.text = "Game Over! Press 'R' to Retry";
        hasLost = true;
    }
   
}
