using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{
    Animation Animation;
    void Start()
    {
        Animation = GetComponent<Animation>();
        Animation.Play();
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        yield return new WaitForSecondsRealtime(8);
        gameObject.SetActive(false);
    }

}
