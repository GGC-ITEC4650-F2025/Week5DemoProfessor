using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    Transform playerTran;
    // Start is called before the first frame update
    void Start()
    {
        playerTran = GameObject.Find("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = playerTran.position - transform.position;
        transform.position += v.normalized * Time.deltaTime;
    }
}
