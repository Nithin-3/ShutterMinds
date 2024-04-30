using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class loadse : MonoBehaviour
{
    VideoPlayer player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<VideoPlayer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((player.frame) > 0 && (player.isPlaying == false))
        {
            SceneManager.LoadScene(2);

        }


    }
}
