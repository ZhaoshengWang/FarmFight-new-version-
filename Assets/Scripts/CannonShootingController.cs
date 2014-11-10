using UnityEngine;
using System.Collections;

public class CannonShootingController : MonoBehaviour {
	public GameObject cannonBallMaterial;
	public GameObject cannonCamera;

	void Start () {
	
	}
	

	void Update () {
		if (Input.GetButton ("Fire1")) {
			Vector3 respawnPosition = new Vector3(cannonCamera.transform.position.x+0.2f,cannonCamera.transform.position.y+0.1f,cannonCamera.transform.position.z);
			GameObject cannonBall= (GameObject)Instantiate(cannonBallMaterial,respawnPosition,cannonCamera.transform.rotation);
			cannonBall.rigidbody.AddForce (cannonCamera.transform.forward*50f,ForceMode.Impulse);
		}
	
	}
}
