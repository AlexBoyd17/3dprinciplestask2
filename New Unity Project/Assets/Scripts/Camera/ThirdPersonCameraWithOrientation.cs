using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCameraWithOrientation : MonoBehaviour {

    public GameObject target;
    Vector3 offset;
    public float smoothTime = 0.3f;
    private float yVelocity = 0.0f;



	// Use this for initialization
	void Start ()
    {
        offset = transform.position - target.transform.position;
	}
	
    void LateUpdate()
    {
        float currentAngle = transform.eulerAngles.y;
        float desiredAngle = target.transform.eulerAngles.y;

        float angle = Mathf.SmoothDampAngle(currentAngle, desiredAngle, ref yVelocity, smoothTime);

        Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);

        transform.position = target.transform.position + (rotation * offset);

        transform.LookAt(target.transform);
    }
	
}
