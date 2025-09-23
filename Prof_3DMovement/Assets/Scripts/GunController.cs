using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public float speed;
    InventoryMgr inv;

    // Start is called before the first frame update
    void Start()
    {
        inv = GameObject.Find("Inventory").GetComponent<InventoryMgr>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && inv.getCurrentPrefab() != null)
        {
            GameObject g = Instantiate(inv.getCurrentPrefab(), transform.position, Quaternion.identity);
            g.GetComponent<Rigidbody>().velocity = transform.forward * speed;
        }
    }
}
