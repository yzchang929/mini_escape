using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class DontDestroyvideo : MonoBehaviour
{
    public int A;
    public GameObject[] digitclock;
    // Start is called before the first frame update
    void Start()
    {

        digitclock = GameObject.FindGameObjectsWithTag("digitclock");
    }

    // Update is called once per frame
    void Update()
    {
        A = SceneManager.GetActiveScene().buildIndex;
        if (A >= 1)
        {
            DontDestroyOnLoad(this.gameObject);
            if (digitclock.Length > 1)
            {
                Destroy(digitclock[1]);
            }
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    public void ending()
    {
            this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
            this.gameObject.transform.GetChild(1).gameObject.SetActive(false);
    }
}