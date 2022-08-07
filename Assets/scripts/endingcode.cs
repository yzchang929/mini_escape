using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class endingcode : MonoBehaviour
{
    public InputField input;//密碼輸入框
    public string ans;//密碼設定
    public GameObject error;//顯示錯誤!
    public GameObject correct;//顯示正確的反應(打開下一個panel
    public Text timeleft;
    countdown CD;//叫程式
    DontDestroyvideo ddv;


    void Awake()
    {
        CD = GameObject.FindGameObjectWithTag("digitclock").GetComponent<countdown>();
        ddv = GameObject.FindGameObjectWithTag("digitclock").GetComponent<DontDestroyvideo>();
    }
    // Start is called before the first frame update
    void update()
    {
        input = GameObject.Find("InputField").GetComponent<InputField>();
    }

    // Update is called once per frame
    public void onClick()
    {
        if (input.text == ans)
        {
            correct.SetActive(true);
            CD.onclick();
            timeleft.text = "剩餘時間\n" + CD.timer;
            ddv.ending();
        }
        else
        {
            error.SetActive(true);
        }
    }
}

