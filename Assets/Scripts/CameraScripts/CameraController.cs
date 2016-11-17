﻿using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject followTarget;
    public float cameraFollowSpeed;

    private Vector3 targetPosition;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        targetPosition = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPosition, cameraFollowSpeed * Time.deltaTime);

	}
}
