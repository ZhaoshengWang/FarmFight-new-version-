﻿using UnityEngine;
using System.Collections;

public class firingSpot : MonoBehaviour 
{

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	void OnTriggerEnter(Collider other)
	{
		Vector3 movement = new Vector3(20.0f, 0.0f, 10.0f);
		if(other.tag != "Player")
		{
			other.rigidbody.AddForce(movement * 50.0f * Time.deltaTime);
		}
	}
}