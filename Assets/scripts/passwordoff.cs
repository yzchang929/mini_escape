using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class passwordoff : MonoBehaviour
{
    public string scenescan;
    public string scenepassword;
    public int num;
    public Button button;
    public Sprite image;
    problemsolve ps;
    // Start is called before the first frame update
    void Awake()
    {
        ps = GameObject.FindGameObjectWithTag("problemsolve").GetComponent<problemsolve>();
    }
    void Start()
    {
        if (ps.nopassword >= num)
        {
            button = GetComponent<Button>();
            button.image.sprite = image;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void click()
    {
        if (ps.nopassword >= num)
        {
            SceneManager.LoadScene(scenescan);
            Debug.Log("true");
        }
        else
        {
            SceneManager.LoadScene(scenepassword);
        }
    }
}



