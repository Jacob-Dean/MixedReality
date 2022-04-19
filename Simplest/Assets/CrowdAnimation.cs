using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowdAnimation : MonoBehaviour
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

            if ((Time.time-startTime)>31 & (Time.time-startTime)<40)
            {
                animator.SetInteger("CrowdControl", 2);
            }

            else if((Time.time-startTime)>40 & (Time.time-startTime)<58)
            {
                animator.SetInteger("CrowdControl", 3);
            }

            else if((Time.time-startTime)>58 & (Time.time-startTime)<69)
            {
                animator.SetInteger("CrowdControl", 4);
            }

            else if((Time.time-startTime)>58 & (Time.time-startTime)<85)
            {
                animator.SetInteger("CrowdControl", 5);
            }

            else if((Time.time-startTime)>85 & (Time.time-startTime)<100)
            {
                animator.SetInteger("CrowdControl", 6);
            }
            else if((Time.time-startTime)>100 & (Time.time-startTime)<115)
            {
                animator.SetInteger("CrowdControl", 7);
            }

            else if((Time.time-startTime)>115)
            {
                animator.SetInteger("CrowdControl", 8);
            }
        }
    }
}
