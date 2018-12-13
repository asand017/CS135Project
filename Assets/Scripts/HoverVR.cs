using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class HoverVR : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(OVRInput.GetDown(OVRInput.Button.One)){ // 'A' button on Oculus
			SceneManager.LoadScene("Scenes/Main");
		}
		
		if(OVRInput.GetDown(OVRInput.Button.Two)){ // 'B' button on Oculus
			Application.Quit();
		}
	}
}
