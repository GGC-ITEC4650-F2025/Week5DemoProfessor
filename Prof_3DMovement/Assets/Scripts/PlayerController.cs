using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float rotSpeed;

    private Vector3 myRot;

    CharacterController myCC;

    // Start is called before the first frame update
    void Start()
    {
        myRot = Vector3.zero; // new Vector3(0, 0, 0); 
        myCC = GetComponent<CharacterController>();  
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 dir = transform.forward * v + transform.right * h;
        //transform.position += dir * speed * Time.deltaTime;
        myCC.Move(dir * speed * Time.deltaTime);


        float mx = Input.GetAxis("Mouse X");
        Vector3 r = Vector3.up * mx;
        myRot += r * Time.deltaTime * rotSpeed;
        transform.localEulerAngles = myRot;
    }
}
