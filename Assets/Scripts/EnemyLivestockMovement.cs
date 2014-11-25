using UnityEngine;
using System.Collections;

public class EnemyLivestockMovement : MonoBehaviour 
{
	Transform firingSpot;
	NavMeshAgent nav;
	public bool fired;

	void Awake()
	{
		firingSpot = GameObject.FindGameObjectWithTag("FiringSpot").transform;
		nav = GetComponent<NavMeshAgent>();
		fired = false;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(!fired)
		{
			nav.SetDestination(firingSpot.position);
		}
	}
	
}
