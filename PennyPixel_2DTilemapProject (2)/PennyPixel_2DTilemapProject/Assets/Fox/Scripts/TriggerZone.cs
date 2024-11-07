/*
 * Treasure Keys
 * Assignment 5A
 * Manage the Score UI and point system
 * Handles the trigger zone to win the game
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TriggerZone : MonoBehaviour
{
    public Text winText;
    private bool gameOver = false;
    public GameObject gameObject;

    void Start()
    {
        winText.gameObject.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            winText.text = "You Win! Press 'R' to Play Again";
            winText.gameObject.SetActive(true);
            gameOver = true;
        }
        
        
    }

    void Update()
    {
        if (gameOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}

