using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    void pause (){
        Time.timeScale = 0;
    }
    void resume()
    {
        Time.timeScale = 1.0f;
    }
}
