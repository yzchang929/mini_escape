using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemToBag : MonoBehaviour
{
    static ItemToBag instance;
    public int StageNow = 1;
    public Item Item_1;
    public Item Item_2;

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
        }
    }


    public void AddCore(Item TargetItem)
    {
        if (!playerinventory.ItemList.Contains(TargetItem))
        {
            playerinventory.ItemList.Add(TargetItem);
            if(GameObject.Find("Canvas").GetComponent<MoveButton>().ButtonNow== StageNow)//
                InventoryManager.CreatNewItem(TargetItem);
        }
    }
    
}
