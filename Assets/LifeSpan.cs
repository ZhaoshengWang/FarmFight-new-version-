using UnityEngine;
using System.Collections;

public class LifeSpan : MonoBehaviour 
{
	public float lifespan;
	public float reproduce;
	float initializedValue;
	public GameObject baby;

	// Use this for initialization
	void Start () 
	{
		initializedValue = reproduce;
	}
	
	// Update is called once per frame
	void Update () 
	{
		lifespan -= Time.deltaTime;
		reproduce -= Time.deltaTime;

		if(lifespan <= 0)
		{
			Destroy(gameObject);
		}

		if(reproduce <= 0)
		{
			int spawnPointIndex = Random.Range (0, 3);
			Instantiate (baby, gameObject.transform.position, gameObject.transform.rotation);
			reproduce = initializedValue;
		}
	}
}
