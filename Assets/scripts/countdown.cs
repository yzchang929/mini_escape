using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class countdown : MonoBehaviour
{
    public int m_seconds;                 //倒數計時經換算的總秒數
    public int m_min;              //用於設定倒數計時的分鐘
    public int m_sec;              //用於設定倒數計時的秒數
    public Text m_timer;           //設定畫面倒數計時的文字
    public GameObject stop;
    public string timer;
    public GameObject[] overlap;

    IEnumerator mycountdown;

    void Start()
    {
        overlap = GameObject.FindGameObjectsWithTag("digitclock");
        mycountdown = Countdown();
        StartCoroutine(mycountdown);   //呼叫倒數計時的協程

    }

    IEnumerator Countdown()
    {
        m_timer.text = string.Format("{0}:{1}", m_min.ToString("00"), m_sec.ToString("00"));
        m_seconds = (m_min * 60) + m_sec;       //將時間換算為秒數

        while (m_seconds > 0)                   //如果時間尚未結束
        {
            yield return new WaitForSeconds(1); //等候一秒再次執行

            m_seconds--;                        //總秒數減 1
            m_sec--;                            //將秒數減 1

            if (m_sec < 0 && m_min > 0)         //如果秒數為 0 且分鐘大於 0
            {
                m_min -= 1;                     //先將分鐘減去 1
                m_sec = 59;                     //再將秒數設為 59
            }
            else if (m_sec < 0 && m_min == 0)   //如果秒數為 0 且分鐘大於 0
            {
                m_sec = 0;                      //設定秒數等於 0
            }
            m_timer.text = string.Format("{0}:{1}", m_min.ToString("00"), m_sec.ToString("00"));
            //DontDestroyOnLoad(this.gameObject);
            
        }

        yield return new WaitForSeconds(1);   //時間結束時，顯示 00:00 停留一秒
        SceneManager.LoadScene("failscene");
                          
    }
    //暫停計時
    private void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex < 1)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
            if (overlap.Length > 1)
            {
                Destroy(overlap[1]);
            }
        }
    }
    public void onclick()
    {
        StopCoroutine(mycountdown);
        Debug.Log("pressed");
        timer = m_timer.text;
    }
}