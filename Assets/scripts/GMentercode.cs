using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GMentercode : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField answer1;//宣告輸入答案answer1
    public int playeranswer1;//宣告玩家輸入值playeranswer1
    public int correctanswer=1234;//正確答案
    public Text errorMessage;//提示訊息
    
    void Start()
    {
        int.TryParse(answer1.text,out playeranswer1);
        if ( playeranswer1 == correctanswer )
        {
            
        }
        else
        {
            //void UpdateerrorMessage(string message)
            //{
               // errorMessage.text = message;
            //}
            
        }
    }
    
    void Update()
    {
        
    }
}
