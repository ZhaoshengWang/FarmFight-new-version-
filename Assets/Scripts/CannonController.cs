using UnityEngine;
using System.Collections;

public class CannonController : MonoBehaviour {
	public GameObject cannonCamera;
	float verticalRotation = 0;
	

	void Update () {
		float horizontalRotation = Input.GetAxis ("Mouse X") * 3.0f;
		transform.Rotate (0, horizontalRotation, 0);

		verticalRotation -= Input.GetAxis ("Mouse Y") * 3.0f;
		verticalRotation = Mathf.Clamp (verticalRotation,-50.0f,50.0f);

		//cannonCamera.transform.Rotate (-verticalRotation, 0, 0);
		cannonCamera.transform.localRotation = Quaternion.Euler (verticalRotation,0,0);

	}
}
