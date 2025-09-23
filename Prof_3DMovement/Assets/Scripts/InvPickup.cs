using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvPickup : MonoBehaviour
{
    public int inventoryIndex;
    InventoryMgr inv;

    // Start is called before the first frame update
    void Start()
    {
        inv = GameObject.Find("Inventory").GetComponent<InventoryMgr>();
    }

    void OnTriggerEnter(Collider other)
    {
        GameObject otherGO = other.gameObject;
        if (otherGO.tag == "Player")
        {
            inv.currentIndex = inventoryIndex;
            Destroy(gameObject);
        }
    }
}
