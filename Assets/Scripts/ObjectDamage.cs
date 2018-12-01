using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDamage : MonoBehaviour {
	
	private Rigidbody rb;
	public int points; //point value for object
    public double destroyForce;
    float totalDamage;
	
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
        totalDamage = 0.0f;
	}


	void DestroyObj () {
		GameMaster.incrementPts(points);
		Destroy(this.gameObject);
	}
	
	void OnCollisionEnter(Collision collision){
        // Vector3 f = collision.rigidbody.mass * collision.relativeVelocity;
        
        Vector3 f = collision.relativeVelocity;
        if(collision.gameObject.tag == "playerhand"){
            rb.AddForce(f*100);
        }
        float force = f.magnitude;
        totalDamage += force;
        Debug.Log("total damage taken: " + totalDamage);
        if (totalDamage > destroyForce)
        {
            Invoke("DestroyObj", 2);
        }

        

    }
}
