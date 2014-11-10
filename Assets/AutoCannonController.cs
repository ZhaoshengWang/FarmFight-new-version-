using UnityEngine;
using System.Collections;

public class AutoCannonController : MonoBehaviour {

	public GameObject cannonBallMaterial;
	float leftRightSpeed = 0;
	float fowardSpeed =0;
	int count = 0;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
			Vector3 respawnPosition = new Vector3(transform.position.x-2f,transform.position.y+8f,transform.position.z);
			GameObject cannonBall= (GameObject)Instantiate(cannonBallMaterial,respawnPosition,transform.rotation);
			cannonBall.rigidbody.AddForce (transform.forward*50f,ForceMode.Impulse);
			if (count < 301) {
						leftRightSpeed += 0.1f;	
						fowardSpeed += 0.1f;
						count ++;
			if (count == 300){count = 1000;}
			} 
			
			if (count >= 301){
						
						leftRightSpeed -= 0.1f;	
						fowardSpeed -= 0.1f;
						count --;
					if (count == 301){count = -300;}
				}
			Vector3 movement = new Vector3 (leftRightSpeed, 0, fowardSpeed);
			movement = transform.rotation * movement;
		
			CharacterController cc = GetComponent<CharacterController> ();
			cc.SimpleMove (movement);
	
	}
}
