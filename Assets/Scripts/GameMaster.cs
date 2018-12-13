using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour {

	private static int points;
	private static double gameTime;
	private double currTime;
	public static bool gameOver;
	public double initialTime;
    public static  AudioSource coin;
    private static int coincounter;
    private static bool coinbool;
    public static int finalScore;
    public static int  topScore;
   
	
	// Use this for initialization
	void Start () {
		//gameTime = 120; //2 minutes
		gameTime = initialTime;
		currTime = Time.time;
		points = 0;
		gameOver = false;
        coin = GetComponent<AudioSource>();
        coinbool = false;
        coincounter = 50; 
	}
	
	public static void incrementPts (int p){
		points = points + p;
        if(points >= coincounter)
        {
            coincounter += 50;
            coinbool = true;
        }
	}
	
	public static int getPts(){
		return points;
	}
	
	public static double getTime(){
		return gameTime;
	}
    public static void PlayAudio()
    {
        if (coinbool)
        {
            coin.Play();
            coinbool = false;
        }
        
    }
    public static bool getGameOver()
    {
        return gameOver;
    }

	
	// Update is called once per frame
	void Update () {
		if(Time.time > (currTime + 1)){
			currTime = Time.time;
			gameTime = gameTime - 1;
		}
		
		if(gameTime == 0){
            finalScore = points;
            if (finalScore > topScore)
                topScore = finalScore;
			gameOver = true;
		}
		
	}
}
