using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ReptarRoar : MonoBehaviour {

    public GameObject roarObject;
    public AudioSource roar;
    private int roarcount;
    private bool roarbool;
    // Use this for initialization
    private double waitTime;
	void Start () {
        roarcount = 0;
        roar = GetComponent<AudioSource>();
        waitTime = Time.time + 2; 
	}

    // Update is called once per frame
    void Update()
    {

        if (GameMaster.gameOver == false)
        {   if(waitTime < Time.time)
            {
                if (GameMaster.getPts() >= roarcount)
                {
                    if (OVRInput.GetDown(OVRInput.Button.One))
                    {
                        Reptarroar();
                        roar.Play();
                        roarbool = false;
                        roarcount += 1000;
                    }
                }
            }
            
            if (OVRInput.GetDown(OVRInput.Button.Four))
            {
                SceneManager.LoadScene("Scenes/StartingMenu");
            }
        }
        else
        {
            if (OVRInput.GetDown(OVRInput.Button.One))
            { // 'A' button on Oculus
                SceneManager.LoadScene("Scenes/Main");
            }
            if (OVRInput.GetDown(OVRInput.Button.Two))
            { // 'B' button on Oculus
                SceneManager.LoadScene("Scenes/StartingMenu");
            }
        }
    }
    void Reptarroar()
    {
        GameObject r;
        r = Instantiate(roarObject, transform.TransformPoint(Vector3.forward * 1), transform.rotation);
        //r.GetComponent<Rigidbody>().AddForce(transform.forward * 2000000);

    }
}
