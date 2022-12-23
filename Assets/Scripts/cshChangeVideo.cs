using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;


public class cshChangeVideo : MonoBehaviour
{
    public VideoClip[] videos;
    private int iVideo = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Gaze를 통합 입력으로 수정해야 함!!
        {
            GetComponent<VideoPlayer>().clip = videos[iVideo];
            iVideo++;
            if (iVideo >= videos.Length) iVideo = 0;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

}
