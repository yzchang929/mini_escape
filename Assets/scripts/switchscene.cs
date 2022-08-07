using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switchscene : MonoBehaviour
{
    public string scenename;
    public void onClick()
    {
        SceneManager.LoadScene(scenename);
    }
    // Start is called before the first frame update
    public void Back()
    {
        SceneManager.LoadScene("關卡");
    }

}
