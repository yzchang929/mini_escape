using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class DontDestroyvideo : MonoBehaviour
{
    public int A;
    public GameObject[] clocks;
    // Start is called before the first frame update
    void Start()
    {   
       clocks = GameObject.FindGameObjectsWithTag("clock");
    }

    // Update is called once per frame
    void Update()
    {
        A = SceneManager.GetActiveScene().buildIndex;
        if (A >= 1)
        {
            DontDestroyOnLoad(this.gameObject);
            if (clocks.Length > 1)
            {
                Destroy(clocks[1]);
            }
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
