using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class VideoWithUIButton : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject uiButton;

    void Start()
    {
        uiButton.SetActive(false);
        videoPlayer.loopPointReached += OnVideoEnd;
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        uiButton.SetActive(true);
    }
}
