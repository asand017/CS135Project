using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReptarRoar : MonoBehaviour {

    public AudioSource roar;
    private int roarcount;
    private bool roarbool;
	// Use this for initialization
	void Start () {
        roarcount = 0;
        roar = GetComponent<AudioSource>();	
	}

    // Update is called once per frame
    void Update()
    {
        if(GameMaster.getPts() >= roarcount)
        {
            roarbool = true;
            roarcount += 1000; 
        }

        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            roar.Play();
            roarbool = false; 


        }

    }
}
