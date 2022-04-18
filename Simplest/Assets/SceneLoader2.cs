using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader2 : MonoBehaviour
{
    public float startTime=0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (startTime==0)
        {
            startTime=Time.time;
        }
        var timePassed=Time.time-startTime;

        if(timePassed>10)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }

    }
}
// (2.55,3.77,-5.776)
//point
//3
//4
//no shadow
//draw halo

//mixed
