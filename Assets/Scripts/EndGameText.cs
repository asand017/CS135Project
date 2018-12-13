using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGameText : MonoBehaviour {

    Text EndGame;
    // Use this for initialization
    void Start () {
		EndGame = GetComponent<Text>(); 
    }
	
	// Update is called once per frame
	void Update () {
        if(GameMaster.getGameOver() == true)
        {
            EndGame.enabled = true; 
        }
        else
        {
            EndGame.enabled = false;
        }
        EndGame.text = "Game Over!\n Your score: " + GameMaster.finalScore + "\nTop Score: " + GameMaster.topScore+"\n Press A to Restart\nPress B to Return to Main Menu";
    }
}
