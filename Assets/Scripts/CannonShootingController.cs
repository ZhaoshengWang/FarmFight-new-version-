using UnityEngine;
using System.Collections;

public class CannonShootingController : MonoBehaviour {
	public GameObject cannonBallMaterial;
	public GameObject cannonCamera;

	void Start () {
	
	}
	

	void Update () {
		if (Input.GetButton ("Fire1")) {
			GameObject cannonBall= (GameObject)Instantiate(cannonBallMaterial,cannonCamera.transform.position,cannonCamera.transform.rotation);
			cannonBall.rigidbody.AddForce (cannonCamera.transform.forward*100f,ForceMode.Impulse);
		}
	
	}
}
