using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	public GameObject ThirdPersonViewCamera;
	public GameObject FirstPersonViewCamera;
	public GameObject Minimap;
	//public GameObject player;

	void Update () {
		if (Input.GetKey (KeyCode.F1)) {
			ThirdPersonViewCamera.SetActive(false);
			//player.SetActive(false);
			Screen.lockCursor = true;
			FirstPersonViewCamera.SetActive(true);

			Minimap.SetActive(true);
			
		}
		if (Input.GetKey (KeyCode.F2)) {
			FirstPersonViewCamera.SetActive(false);
			//player.SetActive(true);
			Screen.lockCursor = false;
			ThirdPersonViewCamera.SetActive(true);

			Minimap.SetActive(true);
			
		}
	
	}
}
