using UnityEngine;
using System.Collections;

public class EnemyLivestockMovement : MonoBehaviour 
{
	Transform firingSpot;
	NavMeshAgent nav;

	void Awake()
	{
		firingSpot = GameObject.FindGameObjectWithTag("FiringSpot").transform;
		nav = GetComponent<NavMeshAgent>();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		nav.SetDestination(firingSpot.position);
	}
	
}
