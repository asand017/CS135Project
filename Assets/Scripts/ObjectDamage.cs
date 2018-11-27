using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDamage : MonoBehaviour {
	
	private Rigidbody rb;
	bool destroy;
	public int points; //point value for object
    public double destroyForce; 
	
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		destroy = false;
	}

	void DestroyObj () {
		GameMaster.incrementPts(points);
		Destroy(this.gameObject);
	}
	
	void OnCollisionEnter(Collision collision){
        if(collision != null)
        {
            Vector3 f = collision.rigidbody.mass * collision.relativeVelocity;
            float force = f.magnitude;
            Debug.Log(force);
            if (force > destroyForce)
            {
                Invoke("DestroyObj", 2);
            }

        }

    }
}
