using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    Transform playerTran;

    NavMeshAgent myAgent;
    ParticleSystem myPS;

    // Start is called before the first frame update
    void Start()
    {
        playerTran = GameObject.Find("Player").GetComponent<Transform>();
        myAgent = GetComponent<NavMeshAgent>();
        myPS = GetComponent<ParticleSystem>();
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

    private void OnCollisionEnter(Collision collision)
    {
        GameObject otherGO = collision.gameObject;
        //Do Stuff
        if (otherGO.tag == "WaterDmg")
        {
            Destroy(gameObject);
        }
        else if (otherGO.tag == "FireDmg")
        {
            //make sparks fly
            myPS.Play();
        }

    }
}
