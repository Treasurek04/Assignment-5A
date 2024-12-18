﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemBehaviour : MonoBehaviour
{
	[Header("References")]
	public GameObject gemVisuals;
	public GameObject collectedParticleSystem;
	public CircleCollider2D gemCollider2D;
	public int gemPoints = 1;

	private float durationOfCollectedParticleSystem;

    private ScoreManager scoreManager;


    void Start()
	{
		durationOfCollectedParticleSystem = collectedParticleSystem.GetComponent<ParticleSystem>().main.duration;

        scoreManager = GameObject.FindObjectOfType<ScoreManager>();
    }

	void OnTriggerEnter2D(Collider2D theCollider)
	{
		if (theCollider.CompareTag ("Player")) {
			GemCollected ();
		}
	}

	void GemCollected()
	{
		gemCollider2D.enabled = false;
		gemVisuals.SetActive (false);
		collectedParticleSystem.SetActive (true);
		Invoke ("DeactivateGemGameObject", durationOfCollectedParticleSystem);

        if (scoreManager != null)
        {
            scoreManager.AddScore(gemPoints);
        }

    }

	void DeactivateGemGameObject()
	{
		gameObject.SetActive (false);
	}
}
