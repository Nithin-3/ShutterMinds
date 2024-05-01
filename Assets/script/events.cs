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
    public void play(int val)
    {
        TrigerPausePlay(false);
        SceneManager.LoadScene(val);
    }
    public void quit()
    {
        Application.Quit();
    }
    public static void gameover()
    {
        events.TrigerPausePlay(true);
        GameObject.FindGameObjectWithTag("over").GetComponent<CanvasGroup>().alpha = 1.0f;
    }
}
