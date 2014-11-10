using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	public GameObject ThirdPersonViewCamera;
	public GameObject FirstPersonViewCamera;
	public GameObject Minimap;
	public GameObject player;
	public GameObject Cannon;
	public GameObject bombObject;
	public GameObject Wall;
	//public GameObject PlayerPlane;
	//public GameObject EnemyPlane;
	public GameObject Plane;
	void Start(){
		for (int i = 0; i < 25; i++) {
		Vector3 spawnPosition = new Vector3(Random.Range(-50,100),
		                                    Random.Range(0,300),Random.Range(-100,100));
			Quaternion spawnRotation = Quaternion.identity;
			Instantiate (bombObject, spawnPosition, spawnRotation);

		}
	}
	void Update () {

		if (Input.GetKey (KeyCode.F1)) {
			ThirdPersonViewCamera.SetActive(false);
			player.SetActive(false);
			Screen.lockCursor = true;
			FirstPersonViewCamera.SetActive(true);
			Cannon.SetActive(false);

			Minimap.SetActive(false);
			
		}
		if (Input.GetKey (KeyCode.F2)) {
			FirstPersonViewCamera.SetActive(false);
			player.SetActive(true);
			Screen.lockCursor = false;
			ThirdPersonViewCamera.SetActive(true);
			Cannon.SetActive(false);

			Minimap.SetActive(true);
			
		}
		if (Input.GetKey (KeyCode.F3)) {
			FirstPersonViewCamera.SetActive(false);
			player.SetActive(false);
			Screen.lockCursor = true;
			ThirdPersonViewCamera.SetActive(false);		
			Minimap.SetActive(false);

			Cannon.SetActive(true);
			
		}

		if (Input.GetKey (KeyCode.T)) {
			float x = Plane.transform.rotation.x-1f;
			Plane.transform.Rotate(x,0f,0f);
			//float wallX = Wall.transform.rotation.x-1f;
			//Wall.transform.Rotate(wallX,0f,0f);
			Wall.SetActive(false);

		}
		if (Input.GetKey (KeyCode.R)) {
			float x = Plane.transform.rotation.x+1f;
			Plane.transform.Rotate(x,0f,0f);
			//float wallX = Wall.transform.rotation.x+1f;
			//Wall.transform.Rotate(wallX,0f,0f);
			Wall.SetActive(false);
		}

		if (Input.GetKey (KeyCode.G)) {
			Physics.gravity = new Vector3(20f,-9.81f,0f);

		}
		if (Input.GetKey (KeyCode.H)) {
			Physics.gravity = new Vector3(-20f,-9.81f,0f);		
		}
		if (Input.GetKey (KeyCode.J)) {
			Physics.gravity = new Vector3(0f,-9.81f,0f);		
		}


	
	}
}
