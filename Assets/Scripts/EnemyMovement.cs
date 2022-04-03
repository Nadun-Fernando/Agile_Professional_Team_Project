using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AI;


public class EnemyMovement : MonoBehaviour
{
    private Transform target;
    private NavMeshAgent navMeshAgent;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("farmerman").transform;
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        navMeshAgent.SetDestination(target.position);
    }
}
