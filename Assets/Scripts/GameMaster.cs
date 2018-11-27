using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour {

	private static int points;
	private static double gameTime;
	private double currTime;
	private bool gameOver;
	public double initialTime;
	
	// Use this for initialization
	void Start () {
		//gameTime = 120; //2 minutes
		gameTime = initialTime;
		currTime = Time.time;
		points = 0;
		gameOver = false;
	}
	
	public static void incrementPts (int p){
		points = points + p;
	}
	
	public static int getPts(){
		return points;
	}
	
	public static double getTime(){
		return gameTime;
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time > (currTime + 1)){
			currTime = Time.time;
			gameTime = gameTime - 1;
		}
		
		if(gameTime <= 0){
			gameOver = true;
		}
		
	}
}
