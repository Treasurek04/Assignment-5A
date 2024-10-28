using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemCollision : MonoBehaviour
{
    public ScoreManager scoreManager;
    public int gemPoints = 1;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            scoreManager.AddScore(gemPoints);
        }
    }
}
