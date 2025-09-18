using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    Transform playerTran;

    NavMeshAgent myAgent;

    // Start is called before the first frame update
    void Start()
    {
        playerTran = GameObject.Find("Player").GetComponent<Transform>();
        myAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        // move directly
        //Vector3 v = playerTran.position - transform.position;
        //transform.position += v.normalized * Time.deltaTime;
        //transform.forward = v;

        myAgent.SetDestination(playerTran.position);
    }
}
