﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour {

	Text score;
	// Use this for initialization
	void Start () {
		score = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		score.text = "Score: " + GameMaster.getPts() + "\nTime Remaining: " + GameMaster.getTime();
		
	}
}