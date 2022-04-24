using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoodTrigger : MonoBehaviour
{
    Animator animator;
    public float startTime=0f;
    public bool wardenTrigger=false;
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

            if((Time.time-startTime)>15 & (Time.time-startTime)<16)
            {
                animator.SetInteger("Stage", 1);
            }
            else if((Time.time-startTime)>16 & (Time.time-startTime)<21) // Hood comes down #1
            {
                animator.SetInteger("Stage", 2);
            }

            // suspense period #1  

            else if((Time.time-startTime)>22 & (Time.time-startTime)<27) // Hood goes back up #1
            {
                animator.SetInteger("Stage", 3);
            }

     

            else if((Time.time-startTime)>27 & (Time.time-startTime)<28)
            {
                animator.SetInteger("Stage", 4);
            }

            // Executioner dilemma #1

            else if((Time.time-startTime)>43 & (Time.time-startTime)<44)
            {
                animator.SetInteger("Stage", 5);
            }
            else if((Time.time-startTime)>44 & (Time.time-startTime)<49) // Hood comes down
            {
                animator.SetInteger("Stage", 6);
            }

            // suspense period 

            else if((Time.time-startTime)>50 & (Time.time-startTime)<55) // Hood goes back up
            {
                animator.SetInteger("Stage", 7);
            }

     

            else if((Time.time-startTime)>55 & (Time.time-startTime)<56)
            {
                animator.SetInteger("Stage", 8);
            }
            // Executioner dilemma

            else if((Time.time-startTime)>71 & (Time.time-startTime)<72)
            {
                animator.SetInteger("Stage", 9);
            }
            else if((Time.time-startTime)>72 & (Time.time-startTime)<77) // Hood comes down
            {
                animator.SetInteger("Stage", 10);
            }

            // suspense period


            else if((Time.time-startTime)>78 & (Time.time-startTime)<83) // Hood goes back up
            {
                animator.SetInteger("Stage", 11);
            }


            else if((Time.time-startTime)>83 & (Time.time-startTime)<84)
            {
                animator.SetInteger("Stage", 12);
            }
            
            // Executioner dilemma

            else if((Time.time-startTime)>85)
            {
                wardenTrigger=true;
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
