﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float turnSmoothValue = 15f;
	public float speedDampTime = 0.1f;
	public float speed;

	//private Animator anim;
	

	void FixedUpdate(){

		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");
		if (h == 0f && v == 0f) {
			rigidbody.Sleep();		
		}
		DoMovement (h, v);

	}

	void DoMovement(float h, float v){

						DoRotate (h, v);
						//anim.SetFloat(hash.speedFloat, 5.5f, speedDampTime, Time.deltaTime);
						Vector3 movement = new Vector3 (h, 0.0f, v);
						rigidbody.AddForce (movement * speed * Time.deltaTime);
						//CharacterController cc = GetComponent<CharacterController> ();
						//cc.SimpleMove (movement*1000*Time.deltaTime);
		
	}
	void DoRotate(float h, float v){

		Vector3 headTo = new Vector3(v, 0f, h);
		Quaternion rotation = Quaternion.LookRotation(Vector3.up,headTo);
		Quaternion newRotation = Quaternion.Lerp(rigidbody.rotation, rotation, turnSmoothValue * Time.deltaTime);
		rigidbody.MoveRotation(newRotation);

	}
}
