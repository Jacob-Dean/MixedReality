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
            else if((Time.time-startTime)>6 & (Time.time-startTime)<11) // Hood comes down #1
            {
                animator.SetInteger("Stage", 2);
            }

            // suspense period #1  

            else if((Time.time-startTime)>16 & (Time.time-startTime)<21) // Hood goes back up #1
            {
                animator.SetInteger("Stage", 3);
            }

            // Executioner dilemma #1

            else if((Time.time-startTime)>31 & (Time.time-startTime)<32)
            {
                animator.SetInteger("Stage", 4);
            }
            else if((Time.time-startTime)>35 & (Time.time-startTime)<36)
            {
                animator.SetInteger("Stage", 5);
            }
            else if((Time.time-startTime)>36 & (Time.time-startTime)<41) // Hood comes down
            {
                animator.SetInteger("Stage", 6);
            }

            // suspense period 

            else if((Time.time-startTime)>46 & (Time.time-startTime)<51) // Hood goes back up
            {
                animator.SetInteger("Stage", 7);
            }

            // Executioner dilemma

            else if((Time.time-startTime)>61 & (Time.time-startTime)<62)
            {
                animator.SetInteger("Stage", 8);
            }
            else if((Time.time-startTime)>65 & (Time.time-startTime)<66)
            {
                animator.SetInteger("Stage", 9);
            }
            else if((Time.time-startTime)>66 & (Time.time-startTime)<71) // Hood comes down
            {
                animator.SetInteger("Stage", 10);
            }

            // suspense period


            else if((Time.time-startTime)>76 & (Time.time-startTime)<81) // Hood goes back up
            {
                animator.SetInteger("Stage", 11);
            }

            // Executioner dilemma

            else if((Time.time-startTime)>91 & (Time.time-startTime)<92)
            {
                animator.SetInteger("Stage", 12);
            }
        }
// (5.25,3.92,-10.96)
// (3.153,2.391,-10.075)

// (3.153,3.336,-10.45)
// (3.153,2.391,-10.075)

// (3.153,3.336,-1.526)
// (3.153,3.336,-10.45)
    }
}
