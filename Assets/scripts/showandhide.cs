using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class showandhide : MonoBehaviour
{
    public GameObject a;
    public GameObject b;
    public GameObject c;
    public GameObject d;
    public GameObject e;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShowAndHide());
    }

    // Update is called once per frame
    IEnumerator ShowAndHide()
    {
        a.SetActive(true);
        yield return new WaitForSeconds(2);
        a.SetActive(false);
        b.SetActive(true);
        yield return new WaitForSeconds(2);
        b.SetActive(false);
        c.SetActive(true);
        yield return new WaitForSeconds(2);
        c.SetActive(false);
        d.SetActive(true);
        yield return new WaitForSeconds(2);
        e.SetActive(true);


    }
}


