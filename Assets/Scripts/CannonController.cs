using UnityEngine;
using System.Collections;

public class CannonController : MonoBehaviour {
	public GameObject cannonCamera;
	float verticalRotation = 0;
	public GameObject cannonModal;
	

	void Update () {
		float horizontalRotation = Input.GetAxis ("Mouse X") * 3.0f;
		transform.Rotate (0, horizontalRotation, 0);

		verticalRotation -= Input.GetAxis ("Mouse Y") * 3.0f;
		verticalRotation = Mathf.Clamp (verticalRotation,-70.0f,70.0f);

		//cannonCamera.transform.Rotate (-verticalRotation, 0, 0);
		cannonCamera.transform.localRotation = Quaternion.Euler (verticalRotation,0,0);

		cannonModal.transform.Rotate (0, horizontalRotation, 0);
		cannonModal.transform.localRotation = Quaternion.Euler (verticalRotation,0,0);


		
		//transform.Rotate(verticalRotation,0,0);
		//verticalRotation = Mathf.Clamp (verticalRotation,-50.0f,50.0f);
		//		Camera.main.transform.localRotation = Quaternion.Euler (verticalRotation,0,0);
		float leftRightSpeed = Input.GetAxis ("Horizontal")*10f;
		float fowardSpeed = Input.GetAxis ("Vertical")*10f;
		
		Vector3 movement = new Vector3 (leftRightSpeed, 0, fowardSpeed);
		movement = transform.rotation * movement;
		
		CharacterController cc = GetComponent<CharacterController> ();
		cc.SimpleMove (movement);


	}
}
