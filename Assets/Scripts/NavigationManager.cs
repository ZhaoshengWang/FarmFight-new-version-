using UnityEngine;
using System.Collections;

public class NavigationManager : MonoBehaviour {

	public void sceneToChange (string sceneToChange) {
		Application.LoadLevel (sceneToChange);
	}
}
