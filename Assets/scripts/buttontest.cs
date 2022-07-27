using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttontest : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField inputField;
    public GameObject start1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (inputField.text == "1234" && start1.activeSelf != true)
        {
                Debug.Log("yeah");
                start1.SetActive(true);
        }
        else
        {
            Debug.Log(inputField.text);
            return;
        }
    }
    public void ButtonClick()
    {
        Debug.Log("Click");
    }

   
    
    
}


