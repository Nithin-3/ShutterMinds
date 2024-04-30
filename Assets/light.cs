using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject lightobj;
    Light flash;
    public static bool enemy = true;
    public bool invoke = true;
    void Start()
    {
        flash = lightobj.GetComponent<Light>();
    }
    void Update()
    {
        if (invoke)
        {
            if (enemy)
            {
                InvokeRepeating("onoff", 1f, 0.5f);
                enemy = false;
            }
            else
            {
                StartCoroutine(can());
                invoke = false;

            }

        }
    }
    void handleinvoke()
    {
      
    }
    void onoff()
    {
        flash.enabled = !flash.enabled;
        StartCoroutine(waiter());
    }
    IEnumerator waiter()
    {
        yield return new WaitForSecondsRealtime(0.3f);
        flash.enabled = !flash.enabled;
    }
    IEnumerator can()
    {
        yield return new WaitForSecondsRealtime(5f);
        CancelInvoke();

    }
}
