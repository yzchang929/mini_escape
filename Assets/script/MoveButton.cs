using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveButton : MonoBehaviour
{
    public GameObject Button_1;
    public GameObject Button_2;
    public GameObject Button_3;
    public GameObject Button_4;
    public GameObject Button_5;
    public GameObject Button_6;
    public int ButtonNow=1;//陷進去的按鈕


    public void move(int input)
    {
        
            switch (ButtonNow)
            {
                case 1:
                    Button_1.transform.Translate(35, 0, 0);
                    break;
                case 2:
                    Button_2.transform.Translate(35, 0, 0);
                    break;
                case 3:
                    Button_3.transform.Translate(35, 0, 0);
                    break;
                case 4:
                    Button_4.transform.Translate(35, 0, 0);
                    break;
                case 5:
                    Button_5.transform.Translate(35, 0, 0);
                    break;
                case 6:
                    Button_6.transform.Translate(35, 0, 0);
                    break;
            }
        
        ButtonNow = input;
        switch (input)
        {
            case 1:
                Button_1.transform.Translate(-35, 0, 0);
                break;
            case 2:
                Button_2.transform.Translate(-35, 0, 0);
                break;
            case 3:
                Button_3.transform.Translate(-35, 0, 0);
                break;
            case 4:
                Button_4.transform.Translate(-35, 0, 0);
                break;
            case 5:
                Button_5.transform.Translate(-35, 0, 0);
                break;
            case 6:
                Button_6.transform.Translate(-35, 0, 0);
                break;
        }
    }
}
