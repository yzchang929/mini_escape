using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stateChecker : MonoBehaviour
{
    public GameObject GOin;
    // Start is called before the first frame update
    void Start()
    {
    }
    void Update()
    {
        Vector3 scale = new Vector3(0.6784207f, 0.6784207f, 0.6784207f);
        //Debug.Log(GOin.activeInHierarchy);
        if(GOin.activeInHierarchy==false)
        {
            GOin.transform.Rotate(0, 0, 180);
            GOin.transform.localScale = scale;
        }
    }
}
