﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    static InventoryManager instance;

    public Inventory myBag;
    public GameObject slotGrid;
    public Slot slotPrefab;
    public Text itemInfo;

    void Awake()
    {
        if (instance != null)
            Destroy(this);
        instance = this;
    }

    public static void CreatNewItem(Item InputItem)
    {
        //Debug.Log(InputItem);
        Slot newItem = Instantiate(instance.slotPrefab, instance.slotGrid.transform.position, Quaternion.identity);
        newItem.gameObject.transform.SetParent(instance.slotGrid.transform);
        newItem.slotItem = InputItem;
        newItem.slotImage.sprite = InputItem.ItemImage;
    }

}
