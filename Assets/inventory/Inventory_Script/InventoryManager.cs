using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class InventoryManager : MonoBehaviour
{
    static InventoryManager instance;

    public Inventory Stage_1_Inventory;
    public Inventory Stage_2_Inventory;
    public Inventory Stage_3_Inventory;
    //public Inventory Stage_4_Inventory;
    //public Inventory Stage_5_Inventory;
    //public Inventory Stage_6_Inventory;
    private Inventory current_Inventory;

    public GameObject Button_1;
    public GameObject Button_2;
    public GameObject Button_3;
    //public GameObject Button_4;
    //public GameObject Button_5;
    //public GameObject Button_6;
    public int ButtonNow = 1;//陷進去的按鈕

    public GameObject slotGrid;
    public Slot slotPrefab;
    public Text itemInfo;
    private Image IMG ;
    private Sprite Tar ;



    void Awake()
    {
        //Debug.Log("SceneManager.GetActiveScene().name == " + SceneManager.GetActiveScene().name);

        if (instance != null)
            Destroy(this);
        instance = this;

        switch (SceneManager.GetActiveScene().name)
        {
            case "第一關掃描":
                Display_Inventory_core(Stage_1_Inventory, 1);
                break;
            case "第二關掃描":
                Display_Inventory_core(Stage_2_Inventory, 2);
                break;
            case "第三關掃描":
                Display_Inventory_core(Stage_3_Inventory, 3);
                break;
            //case "第四關掃描":
            //    Display_Inventory_core(Stage_4_Inventory, 4);
            //    break;
            //case "第五關掃描":
            //    Display_Inventory_core(Stage_5_Inventory, 5);
            //    break;
            //case "第六關掃描":
            //    Display_Inventory_core(Stage_6_Inventory, 6);
            //    break;
        }
    }

    public static void CreatNewItem(Item InputItem)
    {
        //Debug.Log(InputItem);
        Slot newItem = Instantiate(instance.slotPrefab, instance.slotGrid.transform.position, Quaternion.identity);
        newItem.gameObject.transform.SetParent(instance.slotGrid.transform);
        newItem.slotItem = InputItem;
        newItem.slotImage.sprite = InputItem.ItemImage;
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
                Display_Inventory_core(Stage_1_Inventory, targetStage);
                break;
            case 2:
                Display_Inventory_core(Stage_2_Inventory, targetStage);
                break;
            case 3:
                Display_Inventory_core(Stage_3_Inventory, targetStage);
                break;
            //case 4:
            //    Display_Inventory_core(Stage_4_Inventory, targetStage);
            //    break;
            //case 5:
            //    Display_Inventory_core(Stage_5_Inventory, targetStage);
            //    break;
            //case 6:
            //    Display_Inventory_core(Stage_6_Inventory, targetStage);
            //    break;
        }
    }
    void Display_Inventory_core(Inventory TargetStage_Inventory,int targetStage)
    {
        foreach (Item element in TargetStage_Inventory.ItemList)
        {
            CreatNewItem(element);
        }
        switch (ButtonNow)
        {
            case 1:
                //Button_1.transform.Translate(35, 0, 0);
                IMG = Button_1.transform.GetChild(0).gameObject.GetComponent<UnityEngine.UI.Image>();
                Tar = Resources.Load<Sprite>("n1");
                IMG.sprite = Tar;
                Debug.Log("n1");
                break;
            case 2:
                //Button_2.transform.Translate(35, 0, 0);
                IMG = Button_2.transform.GetChild(0).gameObject.GetComponent<UnityEngine.UI.Image>();
                Tar = Resources.Load<Sprite>("n2");
                IMG.sprite = Tar; 
                break;
            case 3:
                //Button_3.transform.Translate(35, 0, 0);
                IMG = Button_3.transform.GetChild(0).gameObject.GetComponent<UnityEngine.UI.Image>();
                Tar = Resources.Load<Sprite>("n3");
                IMG.sprite = Tar; 
                break;
                //case 4:
                //    Button_4.transform.Translate(35, 0, 0);
                //    break;
                //case 5:
                //    Button_5.transform.Translate(35, 0, 0);
                //    break;
                //case 6:
                //    Button_6.transform.Translate(35, 0, 0);
                //    break;
        }

        ButtonNow = targetStage;
        switch (targetStage)
        {
            case 1:
                //Button_1.transform.Translate(-35, 0, 0);
                IMG = Button_1.transform.GetChild(0).gameObject.GetComponent<UnityEngine.UI.Image>();
                Tar = Resources.Load<Sprite>("Button_1");
                IMG.sprite = Tar;
                break;
            case 2:
                //Button_2.transform.Translate(-35, 0, 0);
                IMG = Button_2.transform.GetChild(0).gameObject.GetComponent<UnityEngine.UI.Image>();
                Tar = Resources.Load<Sprite>("Button_2");
                IMG.sprite = Tar;
                break;
            case 3:
                //Button_3.transform.Translate(-35, 0, 0);
                IMG = Button_3.transform.GetChild(0).gameObject.GetComponent<UnityEngine.UI.Image>();
                Tar = Resources.Load<Sprite>("Button_3");
                IMG.sprite = Tar;
                break;
            //case 4:
            //    Button_4.transform.Translate(-35, 0, 0);
            //    break;
            //case 5:
            //    Button_5.transform.Translate(-35, 0, 0);
            //    break;
            //case 6:
            //    Button_6.transform.Translate(-35, 0, 0);
            //    break;
        }
    }
}
