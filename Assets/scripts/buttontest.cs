using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttontest : MonoBehaviour
{
    // Start is called before the first frame update
    public string a;
    public InputField inputField;
    
    public string scenename;
    public GameObject error;
    // Update is called once per frame

    public void ButtonClick()
    {
        Debug.Log("Click");
        if (inputField.text == a)
        {
            Debug.Log("yeah");
            SceneManager.LoadScene(scenename);
        }
        else
        {
            Debug.Log(inputField.text);
            error.SetActive(true);
        }
    }

   
    
    
}


