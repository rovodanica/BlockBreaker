﻿using UnityEngine;
using System.Collections;

public class OneHitBrick : MonoBehaviour {
	public int maxHits;
	private int timesHit;
	private LevelManager levelManager;
	// Use this for initialization
	
	void Start () {
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		timesHit = 0;
	}
	
	void OnCollisionEnter2D (Collision2D collision){
		timesHit++;
		if(timesHit >= maxHits){
			Destroy (gameObject);
		}
	}
	
	void SimulateWin(){
		levelManager.LoadNextLevel();
	}
}