using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagManager : MonoBehaviour
{
    public Inventory Stage_1_Inventory;
    public Inventory Stage_2_Inventory;
    public Inventory Stage_3_Inventory;
    public Inventory Stage_4_Inventory;
    public Inventory Stage_5_Inventory;
    public Inventory Stage_6_Inventory;
    public GameObject slotGrid;

    public void Awake()
    {
        Display_Inventory_core(Stage_1_Inventory);
    }

    public void OpenStageInventory(int targetStage)
    {
        for (int i = 0; i < slotGrid.transform.childCount; i++)
        {
            GameObject go = slotGrid.transform.GetChild(i).gameObject;
            Destroy(go);
        }//清空包包

        switch (targetStage)
        {
            case 1:
                Display_Inventory_core( Stage_1_Inventory );
                break;
            case 2:
                Display_Inventory_core( Stage_2_Inventory );
                break;
            case 3:
                Display_Inventory_core( Stage_3_Inventory );
                break;
            case 4:
                Display_Inventory_core( Stage_4_Inventory );
                break;
            case 5:
                Display_Inventory_core( Stage_5_Inventory );
                break;
            case 6:
                Display_Inventory_core( Stage_6_Inventory );
                break;
        }
    }
    void Display_Inventory_core(Inventory TargetStage_Inventory)
    {
        foreach (Item element in TargetStage_Inventory.ItemList)
        {
            InventoryManager.CreatNewItem(element);
        }
    } 
}