using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoodTrigger : MonoBehaviour
{
    Animator animator;
    public float startTime=0f;
    // Start is called before the first frame update
    void Start()
    {
        animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("VR Rig").GetComponent<ContinuousMovement>().startCountdown)
        {
            if (startTime==0)
            {
                startTime=Time.time;
            }

            if((Time.time-startTime)>5 & (Time.time-startTime)<6)
            {
                animator.SetInteger("Stage", 1);
            }
            else if(Time.time>7)
            {
                animator.SetInteger("Stage", 2);
            }
        }
// (5.25,3.92,-10.96)
// (3.153,2.391,-10.075)
    }
}
