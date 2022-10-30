using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeText : MonoBehaviour
{
    public Text timeleft;
    public countdown CD;//叫程式

    void Start()
    {
        CD = GameObject.FindGameObjectWithTag("digitclock").GetComponent<countdown>();
        Debug.Log("CD = " + CD);
        timeleft.text = string.Format("{0}:{1}", (59-CD.m_min).ToString("00"),(60- CD.m_sec).ToString("00"));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
