using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class punchingLeft : MonoBehaviour {
    private Collider col;
    public GameObject lhand;
    // Use this for initialization
    void Start()
    {
        col = lhand.GetComponent<Collider>();

    }

    // Update is called once per frame
    void Update()
    {


        // && OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger) && OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger
        if (OVRInput.Get(OVRInput.Touch.PrimaryThumbstick) || OVRInput.Get(OVRInput.Touch.PrimaryThumbRest))
        {
            col.isTrigger = false;

        }
        else
        {
            col.isTrigger = true;
        }
    }
}
