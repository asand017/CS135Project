using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightswitch : MonoBehaviour {
	
	public Light light;

	// Use this for initialization
	void Start () {
		light = GetComponent<Light> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("tab")){
			light.color = new Color(Random.Range(0.0f, 1.0f),Random.Range(0.0f, 1.0f),Random.Range(0.0f, 1.0f));
		}
	}
}
