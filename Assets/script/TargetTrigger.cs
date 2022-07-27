using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class TargetTrigger : MonoBehaviour, ITrackableEventHandler
{
    public Vector3 Scalein;
    public Vector3 Eulerin;
    public GameObject GOin;
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
        if (TB)
        {
            TB.RegisterTrackableEventHandler(this);
        }
    }
    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.TRACKED)
        {
            //Debug.Log("TRACKED");
            //Debug.Log("type = " + TB.TrackableName.GetType());
            if (TB.TrackableName == "table")
                GameObject.Find("GameMa").GetComponent<ItemToBag>().AddNewItem(1);
            else if (TB.TrackableName == "fish")
                GameObject.Find("GameMa").GetComponent<ItemToBag>().AddNewItem(2);
        }
        else
        {
            //Debug.Log("not TRACKED");
            Debug.Log(GOin.transform.localEulerAngles);
            GOin.transform.localRotation = Quaternion.Euler(Eulerin);
            GOin.transform.localScale = Scalein;
        }
    }
}