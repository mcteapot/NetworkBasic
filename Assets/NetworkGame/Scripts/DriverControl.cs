﻿using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput; // muist be imported, used to work on moble

public class DriverControl : MonoBehaviour {


	float speed = 10.0f;
	float rotationSpeed = 100.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		float translation = CrossPlatformInputManager.GetAxis("Vertical") * speed;
		float rotation = CrossPlatformInputManager.GetAxis("Horizontal") * rotationSpeed;

		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;
		transform.Translate(0, 0, translation);
		transform.Rotate(0, rotation, 0);

	}
}
