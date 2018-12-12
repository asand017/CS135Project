using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDamage : MonoBehaviour {
	
	private Rigidbody rb;
	public int points; //point value for object
    public double destroyForce;
    float totalDamage;
    public AudioSource damageSound;
    private float startTime;
    private float nextTime; 

    // Use this for initialization
    void Start () {
        startTime = Time.time;
        nextTime = 0f;
        damageSound = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
        totalDamage = 0.0f;
	}


	void DestroyObj () {
		GameMaster.incrementPts(points);
        GameMaster.PlayAudio();
		Destroy(this.gameObject);
	}
	
	void OnCollisionEnter(Collision collision){
        // Vector3 f = collision.rigidbody.mass * collision.relativeVelocity;
        if (damageSound != null)
        {
            if(Time.time > startTime + nextTime)
            {
                damageSound.Play();
                startTime = Time.time;
                nextTime = 0.5f;

            }
           
        }
        Vector3 f = collision.relativeVelocity;
        float force = f.magnitude;
        totalDamage += force;
       // Debug.Log("total damage taken: " + totalDamage);
        if (totalDamage > destroyForce)
        {
            Invoke("DestroyObj", 2);
        }

        

    }
}
