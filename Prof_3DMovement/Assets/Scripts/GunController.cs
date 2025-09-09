using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject g = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            g.GetComponent<Rigidbody>().velocity = transform.forward * speed;
        }
    }
}
