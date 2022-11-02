using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeImage : MonoBehaviour
{
    public int pageIndex = 1;
    private string change_Target;
    public void init()
    {
        pageIndex = 1;
        this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        if ((Resources.Load<Sprite>(change_Target + (pageIndex+1).ToString())) != null)
            this.gameObject.transform.GetChild(1).gameObject.SetActive(true);
        else
            this.gameObject.transform.GetChild(1).gameObject.SetActive(false);

    }
    public void Set_ChangeTarget(string input)
    {
        change_Target = input;
    }
    public void Change_Image_plus()
    {
        if ((Resources.Load<Sprite>(change_Target + (pageIndex+1).ToString())) != null)
        {
            pageIndex++;
            this.gameObject.GetComponent<UnityEngine.UI.Image>().sprite = Resources.Load<Sprite>(change_Target + pageIndex.ToString());
            this.gameObject.GetComponent<UnityEngine.UI.Image>().SetNativeSize();
        }
        if ((Resources.Load<Sprite>(change_Target + (pageIndex + 1).ToString())) == null)
        {
            this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
            this.gameObject.transform.GetChild(1).gameObject.SetActive(false);
        }
        else if (pageIndex == 1)
        {
            this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
            this.gameObject.transform.GetChild(1).gameObject.SetActive(true);
        }
        else
        {
            this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
            this.gameObject.transform.GetChild(1).gameObject.SetActive(true);
        }
                 if ((Resources.Load<Sprite>(change_Target + (pageIndex + 1).ToString())) == null && pageIndex == 1)
        { 
            this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
            this.gameObject.transform.GetChild(1).gameObject.SetActive(false);
        }   

    }
    public void Change_Image_minor()
    {
        if ((Resources.Load<Sprite>(change_Target + (pageIndex - 1).ToString())) != null)
        {
            pageIndex--;
            this.gameObject.GetComponent<UnityEngine.UI.Image>().sprite = Resources.Load<Sprite>(change_Target + pageIndex.ToString());
            this.gameObject.GetComponent<UnityEngine.UI.Image>().SetNativeSize();

        }

        if (pageIndex == 1)
        {
            this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
            this.gameObject.transform.GetChild(1).gameObject.SetActive(true);
        }
        else
        {
            this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
            this.gameObject.transform.GetChild(1).gameObject.SetActive(true);
        }
    }
}
