using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour {

    public Camera triggeredCam;
    public Camera liveCam;

	void Start () {
		
	}
	
    void OnTriggerEnter(Collider col)
    {
        GameObject PlayerCharacter = GameObject.FindGameObjectWithTag("Player");
        Collider PlayerCollider = PlayerCharacter.GetComponent<Collider>();

        if (col == PlayerCollider)
        {
            liveCam = Camera.allCameras[0];

            triggeredCam.enabled = true;
            liveCam.enabled = false;

            triggeredCam.GetComponent<AudioListener>().enabled = true;
            PlayerCharacter.GetComponent<AudioListener>().enabled = false;
        }
    }

    void OnTriggerExit(Collider col)
    {

    }

    void OnTriggerStay(Collider col)
    {

    }
	// Update is called once per frame
	void Update () {
		
	}
}
