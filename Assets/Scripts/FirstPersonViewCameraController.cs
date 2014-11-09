using UnityEngine;
using System.Collections;

public class FirstPersonViewCameraController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float fowardSpeed = Input.GetAxis ("Vertical");
		Vector3 speed = new Vector3 (0, 0, fowardSpeed);

	
	}
}
