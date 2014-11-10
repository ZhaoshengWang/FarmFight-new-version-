using UnityEngine;
using System.Collections;

public class CannonBallController : MonoBehaviour {

	float lifeDuration = 5.0f;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		lifeDuration = lifeDuration - Time.deltaTime;
		if (lifeDuration <= 0) {
			Explode();		
		}
	
	}
	void Explode(){

		Destroy (gameObject);
	}

}
