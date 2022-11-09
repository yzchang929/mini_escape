using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttontest : MonoBehaviour
{
    public InputField inputField;
    public string ans;
    problemsolve ps;
    public string scenename;
    public GameObject error;
    // Update is called once per frame
    private void Awake()
    {
        ps = GameObject.FindGameObjectWithTag("problemsolve").GetComponent<problemsolve>();
    }
    //private void Update()
    //{
    //    inputField = GameObject.Find("inputField").GetComponent<InputField>();
    //}
    public void ButtonClick()
    {
        Debug.Log("Click");
        if (inputField.text == ans)
        {
            SceneManager.LoadScene(scenename);
            ps.nopassword += 1;
            ps.plus();
        }
        else
        {
            Debug.Log(inputField.text);
            error.SetActive(true);
        }
    }

   
    
    
}


