using System.Collections;
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
        double cTime = GameMaster.getTime();
        if ( cTime < 0)
        {
            cTime = 0;
        }
		score.text = "Score: " + GameMaster.getPts() + "\nTime Remaining: " + cTime;
		
	}
}
