using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class events : MonoBehaviour
{
    public static void TrigerPausePlay(bool pause)
    {
        Time.timeScale = pause ? 0 : 1.0f ;
    }
    public void play()
    {
        SceneManager.LoadScene(1);
    }
    public void quit()
    {
        Application.Quit();
    }
}
