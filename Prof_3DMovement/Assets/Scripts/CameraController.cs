using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float rotSpeed;
    private Vector3 myRot;

    // Start is called before the first frame update
    void Start()
    {
        myRot = Vector3.zero; // new Vector3(0, 0, 0);   
    }

    // Update is called once per frame
    void Update()
    {
        float my = Input.GetAxis("Mouse Y");
        Vector3 r = Vector3.right * -my;
        myRot += r * Time.deltaTime * rotSpeed;
        if (myRot.x > 80)
            myRot.x = 80;
        if (myRot.x < -80)
            myRot.x = -80;
        transform.localEulerAngles = myRot;
    }
}
