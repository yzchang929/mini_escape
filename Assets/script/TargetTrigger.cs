using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class TargetTrigger : MonoBehaviour, ITrackableEventHandler
{
    public Vector3 Scalein;
    public Vector3 Eulerin;
    public GameObject GOin;
    private GameObject jump_Out;
    public string jump_Out_File_Name;

    //取得TrackableBehaviour
    TrackableBehaviour TB
    {
        get
        {
            return GetComponent<TrackableBehaviour>();
        }
    }
    //開始時確認TrackableBehaviour 是否存在，並且註冊它的事件狀態控制
    void Start()
    {
        jump_Out = GameObject.Find("Canvas").transform.GetChild(0).gameObject;
        if (TB)
        {
            TB.RegisterTrackableEventHandler(this);
        }
    }
    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.TRACKED)
        {
            if (TB.TrackableName == "Table" || TB.TrackableName == "textbook_x" || TB.TrackableName == "window")
                GameObject.Find("GameMa").GetComponent<ItemToBag>().AddNewItem(1);//數字代表 GameMain裡ItemToBag的數字
            else if (TB.TrackableName == "fish2" || TB.TrackableName == "card" || TB.TrackableName == "fox")
                GameObject.Find("GameMa").GetComponent<ItemToBag>().AddNewItem(2);
            else if (TB.TrackableName == "red" || TB.TrackableName == "monji" || TB.TrackableName == "bird")
                GameObject.Find("GameMa").GetComponent<ItemToBag>().AddNewItem(3);
            else if (TB.TrackableName == "blue" || TB.TrackableName == "photo" || TB.TrackableName == "littleG")
                GameObject.Find("GameMa").GetComponent<ItemToBag>().AddNewItem(4);
            else if (TB.TrackableName == "green" || TB.TrackableName == "poet" || TB.TrackableName == "magic")
                GameObject.Find("GameMa").GetComponent<ItemToBag>().AddNewItem(5);
            else if (TB.TrackableName == "1-6 Panel" || TB.TrackableName == "2-6 model" || TB.TrackableName == "last")
                GameObject.Find("GameMa").GetComponent<ItemToBag>().AddNewItem(6);
            //Debug.Log("GOin = " + GOin);
            //if (TB.TrackableName == "Table")
            //    GameObject.Find("GameMa").GetComponent<ItemToBag>().AddNewItem(1);
            //else if (TB.TrackableName == "fish2")
            //    GameObject.Find("GameMa").GetComponent<ItemToBag>().AddNewItem(2);
            //else if (TB.TrackableName == "red")
            //    GameObject.Find("GameMa").GetComponent<ItemToBag>().AddNewItem(3);
            //else if (TB.TrackableName == "blue")
            //    GameObject.Find("GameMa").GetComponent<ItemToBag>().AddNewItem(4);
            //else if (TB.TrackableName == "green")
            //    GameObject.Find("GameMa").GetComponent<ItemToBag>().AddNewItem(5);

            if (jump_Out_File_Name !="")
                DisplayJump_Out(jump_Out_File_Name);
        }
        else
        {
            //Debug.Log("not TRACKED");
            //Debug.Log(GOin.transform.localEulerAngles);
            if (jump_Out_File_Name == "")
            {
                GOin.transform.localRotation = Quaternion.Euler(Eulerin);
                GOin.transform.localScale = Scalein;
            }
            jump_Out.SetActive(false);


        }
    }
    private void DisplayJump_Out(string jump_Out_Class)
    {
        jump_Out.SetActive(true);
        jump_Out.GetComponent<ChangeImage>().Set_ChangeTarget(jump_Out_Class);
        jump_Out.GetComponent<ChangeImage>().init();
        jump_Out.GetComponent<UnityEngine.UI.Image>().sprite = Resources.Load<Sprite>(jump_Out_Class + "1");
        jump_Out.GetComponent<UnityEngine.UI.Image>().SetNativeSize();
    }
}