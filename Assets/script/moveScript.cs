using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveScript : MonoBehaviour
{
    public GameObject GOin;
    // Start is called before the first frame update
   
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = GOin.transform.position;
        move = new Vector3(move.x, move.y, move.z + 0.1f);
        //if (Time.time % 2 < 0.5 || Time.time % 2 > 1.5)
        //    GOin.transform.position += GOin.transform.forward * Time.deltaTime * 100;
        //else if (Time.time % 2 < 1.5)
        //    GOin.transform.position += GOin.transform.forward * Time.deltaTime * -100;
        GOin.transform.Rotate(Vector3.up, 360 * Time.deltaTime, Space.Self);
        Debug.Log(Time.deltaTime);
    }
}
