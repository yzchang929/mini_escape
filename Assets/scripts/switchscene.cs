using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switchscene : MonoBehaviour
{
    public void onClick()
    {
        SceneManager.LoadScene("第一關");
    }
    // Start is called before the first frame update
    public void Back()
    {
        SceneManager.LoadScene("關卡");
    }

}
