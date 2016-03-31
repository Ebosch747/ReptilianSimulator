using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

    NavMeshAgent agent;
    Transform target;

	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("leafy").transform;
	}
	
	// Update is called once per frame
	void Update () {
        agent.SetDestination(target.position);
	}
}
