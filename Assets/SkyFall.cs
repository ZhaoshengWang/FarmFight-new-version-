using UnityEngine;
using System.Collections;

public class SkyFall : MonoBehaviour {

	float h= -1000f;


	void Update () {	
		while (transform.position.y >= 7) {
						Vector3 movement = new Vector3 (0, h, 0);
						rigidbody.AddForce (movement * Time.deltaTime);
				
				}

	}

}
