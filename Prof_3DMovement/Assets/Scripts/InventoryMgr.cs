using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class InventoryMgr : MonoBehaviour
{
    public int currentIndex;
    public Sprite[] allIcons;
    public GameObject[] allPrefabs;

    Image iconImg;

    // Start is called before the first frame update
    void Start()
    {
        iconImg = transform.Find("Icon").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentIndex < 0)
        {
            iconImg.enabled = false;
        }
        else
        {
            iconImg.enabled = true;
            iconImg.sprite = allIcons[currentIndex];
        }
    }

    public GameObject getCurrentPrefab()
    {
        if (currentIndex < 0)
            return null;
        return allPrefabs[currentIndex];
    }
}
