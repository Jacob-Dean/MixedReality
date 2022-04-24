using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimePlay : MonoBehaviour
{
    public int timeSpeed;
    public int cutoff;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale=timeSpeed;
 
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.realtimeSinceStartup>cutoff)
        {
            Time.timeScale=1;
        }
    }
}
