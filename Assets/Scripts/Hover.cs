using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class Hover : MonoBehaviour {
	
	private Color colorI = Color.black;
	private Color colorF = new Color (51f/255f,102f/255f,102f/255f);
	
	private float t=0;
	private bool f = true;

	private int fs;

	private int init_f = 230;
	private int final_f = 250;
	private float speed = 2.5f;
	
	Renderer _renderer;

	// Use this for initialization
	void Start () {
		//m = GetComponent<Renderer>().material;
		//m.color = Color.black;
		//_renderer = GetComponent<Renderer>();
		//_renderer.material.color = colorI;


		//init_f = GetComponent<TextMesh>().fontSize;
		//InvokeRepeating("Oscillate", 1.0f, 1.0f);
	}

	//void Oscillate(){
	//	if (f == true){
			//GetComponent<TextMesh>().fontSize = 210;
			//GetComponent<TextMesh>().alignment = TextAlignment.Center;
	//		f = false;
	//	}else{
			//GetComponent<TextMesh>().fontSize = 250;
			//GetComponent<TextMesh>().alignment = TextAlignment.Center;
	//		f = true;
	//	}

	//}
	
	void Update() { 

		float range = final_f - init_f;
		GetComponent<TextMesh>().fontSize = Convert.ToInt32((Mathf.Sin(Time.time * speed) + 1.0) / 2.0 * range + init_f);
		GetComponent<TextMesh>().alignment = TextAlignment.Center;
		if (Input.GetKey(KeyCode.A)){//N)){
		//	_renderer.material.color = colorF;//Color.Lerp(colorI, colorF, Mathf.PingPong(Time.time, 1));
			SceneManager.LoadScene("Scenes/Main");
		}
		
		if (Input.GetKey(KeyCode.B)){//M)){
		//	_renderer.material.color = colorF;//Color.Lerp(colorI, colorF, Mathf.PingPong(Time.time, 1));
			//if(EditorApplication.isPlaying == true){
			//	EditorApplication.isPlaying = false;
			//}
			Application.Quit();
		}
	}

}
