using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NewBehaviourScript : MonoBehaviour
{
    public int playednum ;
    // Start is called before the first frame update
    void Start()
    {
         playednum = PlayerPrefs.GetInt("num");

         if (playednum > 0)
         {
                gameObject.SetActive(false);
         }
         else
         {
                gameObject.SetActive(true);
         }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
