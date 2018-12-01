using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class punchingRight : MonoBehaviour {

    private Collider col;
    public GameObject rhand;
	// Use this for initialization
	void Start () {
        col = rhand.GetComponent<Collider>();

    }
	
	// Update is called once per frame
	void Update () {


       // && OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger) && OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger
        
        if (OVRInput.Get(OVRInput.Touch.SecondaryThumbstick) || OVRInput.Get(OVRInput.Touch.SecondaryThumbRest))
         {
           col.isTrigger= false;

        }else{
            col.isTrigger = true;
        }
	}
}
