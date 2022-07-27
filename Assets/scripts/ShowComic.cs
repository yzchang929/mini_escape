using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShowComic : MonoBehaviour
{
    public int num;
    public void Finishvideo()
    {
        num += 1;
    }
    private void Update()
    {
        if (num!=0)
        {
         PlayerPrefs.SetInt("num", num);
        }
    }
}
