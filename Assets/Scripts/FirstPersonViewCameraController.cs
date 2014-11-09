using UnityEngine;
using System.Collections;

public class FirstPersonViewCameraController : MonoBehaviour {
	//public float speed = 1000f;
	// Use this for initialization

	void Start () {

	}
	
	// Update is called once per frame
	void LateUpdate () {

		float horizontalRotation = Input.GetAxis ("Mouse X") * 3.0f;
		transform.Rotate (0, horizontalRotation, 0);
		float verticalRotation = Input.GetAxis ("Mouse Y") * 3.0f;

		//transform.Rotate(verticalRotation,0,0);
		//verticalRotation = Mathf.Clamp (verticalRotation,-50.0f,50.0f);
//		Camera.main.transform.localRotation = Quaternion.Euler (verticalRotation,0,0);
		float leftRightSpeed = Input.GetAxis ("Horizontal")*10f;
		float fowardSpeed = Input.GetAxis ("Vertical")*10f;

		Vector3 movement = new Vector3 (leftRightSpeed, 0, fowardSpeed);
		movement = transform.rotation * movement;

		CharacterController cc = GetComponent<CharacterController> ();
		cc.SimpleMove (movement);
		//rigidbody.AddForce (movement * speed * Time.deltaTime);
	
	}
}
