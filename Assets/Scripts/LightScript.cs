using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour {
	
	private float startTime = 0.0f;
	private float threeSeconds = 3.0f;
	public Light [] pLights;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		startTime += Time.deltaTime;
		if(startTime > threeSeconds){
			int randomNum = Random.Range(0,3);
			for(int i = 0; i < 3; i++){
				pLights[i].intensity = 0;
			}
			pLights[randomNum].intensity = 3;
			startTime = 0.0f;
		}
	}
}
