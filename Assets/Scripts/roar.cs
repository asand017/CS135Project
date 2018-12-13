using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roar : MonoBehaviour {
    public GameObject roarObject;
	//private bool initiated;
	private float roarTime;
	private float timeDelay = 2f;
	// Use this for initialization
	void Start () {
		//initiated = false;
		roarTime = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		if(OVRInput.GetDown(OVRInput.Button.One) && roarTime + timeDelay < Time.time){
			Reptarroar();
			roarTime = Time.time;
		}
	}

    void Reptarroar()
    {
        GameObject r;
        r = Instantiate(roarObject, transform.TransformPoint(Vector3.forward * 1), transform.rotation);
        //r.GetComponent<Rigidbody>().AddForce(transform.forward * 2000000);

    }
}
