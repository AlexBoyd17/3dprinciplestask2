﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraPosition : MonoBehaviour {

    public Vector3 offset;

    public Transform player;
	
	// Update is called once per frame
	void Update () {
        this.transform.position = player.transform.position + offset;
	}
}
