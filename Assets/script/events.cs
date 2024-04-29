using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class events : MonoBehaviour
{
    public void TrigerPausePlay(bool pause)
    {
        Time.timeScale = pause ? 0 : 1.0f ;
    }
}
