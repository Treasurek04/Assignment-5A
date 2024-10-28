using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    public GameManager gameManager; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        { 
            gameManager.TriggerWin(); 
        }
    }
}
