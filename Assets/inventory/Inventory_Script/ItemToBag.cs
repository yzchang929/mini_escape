using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemToBag : MonoBehaviour
{
    static ItemToBag instance;
    public int StageNow = 1;
    public Item Item_1;
    public Item Item_2;
    public Item Item_3;
    public Item Item_4;
    public Item Item_5;
    public Item Item_6;

    public Inventory playerinventory;

    public void AddNewItem(int ScanInput)
    {
        Debug.Log("ScanInput = " + ScanInput);
        switch (ScanInput)
        {
            case 1:
                AddCore(Item_1);
                break;
            case 2:
                AddCore(Item_2);
                break;
            case 3:
                AddCore(Item_3);
                break;
            case 4:
                AddCore(Item_4);
                break;
            case 5:
                AddCore(Item_5);
                break;
            case 6:
                AddCore(Item_6);
                break;
        }
    }


    public void AddCore(Item TargetItem)
    {
        if (!playerinventory.ItemList.Contains(TargetItem))
        {
            playerinventory.ItemList.Add(TargetItem);
            if(GameObject.Find("Canvas").GetComponent<InventoryManager>().ButtonNow== StageNow)//
                InventoryManager.CreatNewItem(TargetItem);
        }
    }
    
}
