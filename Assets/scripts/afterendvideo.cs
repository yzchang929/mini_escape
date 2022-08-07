using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class afterendvideo : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject over;
    
    void Update()
    {
        if ((videoPlayer.frame) > 0 && (videoPlayer.isPlaying == false))
        {
            Debug.Log("endplay");
            over.SetActive(true);
           
        }
    }

}
