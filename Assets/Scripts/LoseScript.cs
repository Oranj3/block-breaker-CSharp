﻿using UnityEngine;
using System.Collections;

public class LoseScript : MonoBehaviour
{

	private LevelManager levelManager;

	void OnTriggerEnter2D (Collider2D trigger)
	{
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		levelManager.LoadLevel("Lose");
	}
	
	void OnCollisionEnter2D (Collision2D collision)
	{
		print ("collision");
	}
	
}
