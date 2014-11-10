using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour 
{
	public int startingHealth = 100;
	public int currentHealth;
	public Slider healthSlider;

	bool damaged;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void TakeDamage(int amount)
	{
		damaged = true;
		currentHealth -= amount;
		healthSlider.value = currentHealth;
	}
}
