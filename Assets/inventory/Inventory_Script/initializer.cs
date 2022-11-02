using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initializer : MonoBehaviour
{
    public Inventory Stage_1_Inventory;
    public Inventory Stage_2_Inventory;
    public Inventory Stage_3_Inventory;
    // Start is called before the first frame update
    public void Awake()
    {
        Stage_1_Inventory.ItemList.Clear();
        Stage_2_Inventory.ItemList.Clear();
        Stage_3_Inventory.ItemList.Clear();
    }
}
