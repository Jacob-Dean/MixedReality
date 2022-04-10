using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class Spawn : MonoBehaviour
{
    public int spawncount=0;
    public Vector3 spawnposition;

    // Start is called before the first frame update
    void Start()
    {
        spawnposition=new Vector3(0.31f,3.27f,-21.71f);
    }

    // Update is called once per frame

    void Update()
    {
        if (spawncount==0)
        {
            if (transform.position.z<-9 & transform.position.z>-11.3 & transform.position.x>-0.37)
            {
                transform.position=spawnposition;
                spawncount++;
            }
        }

        //transform.position=Vector3.zero;
    }
}
