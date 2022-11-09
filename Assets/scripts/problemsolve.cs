using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class problemsolve : MonoBehaviour
{
    public int nopassword = 0;
    public GameObject[] lap;
    // Start is called before the first frame update
    void Start()
    {
        lap = GameObject.FindGameObjectsWithTag("problemsolve");
    }

    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(this.gameObject);
        if (SceneManager.GetActiveScene().buildIndex < 1)
        {
            Destroy(this.gameObject);
        }
        if (lap.Length>1)
        {
            Destroy(lap[1]);
        }
    }
    public void plus()
    {
        Debug.Log(nopassword);
    }
}
