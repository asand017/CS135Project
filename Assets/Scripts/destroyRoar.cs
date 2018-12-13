using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyRoar : MonoBehaviour {
	// Use this for initialization
	private float timeDelay2 = 0.5f;
	private float timeDelay = 6f;
	private float spheretime = 0f;
	private float destorytime = 0f;
	//private Transform sphere;
	void Start () {
		//sphere.GetComponent<Transform>();
		spheretime = Time.time;
		destorytime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.position += transform.forward* Time.deltaTime* 50.0f;
		if(spheretime + timeDelay2 < Time.time){
			gameObject.transform.localScale += new Vector3(0.1f,0.1f,0.1f);
		}
		if(destorytime + timeDelay < Time.time){
			destorysphere();
		}
	}
	
	void destorysphere(){
		Destroy(gameObject);
	}
}
