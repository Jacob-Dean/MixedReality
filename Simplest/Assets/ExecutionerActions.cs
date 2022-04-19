using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExecutionerActions : MonoBehaviour
{
    // Start is called before the first frame update

    Animator animator;
    public float startTime=0f;
    public float speed;

    void Start()
    {
        animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("VR Rig").GetComponent<ContinuousMovement>().startCountdown)
        {

            var rot = transform.eulerAngles;

            if (startTime==0)
            {
                startTime=Time.time;
            }
            if ((Time.time-startTime)>2 & (Time.time-startTime)<12)
            {
                animator.SetInteger("Executioner", -1);
            }
            else if ((Time.time-startTime)>12 & (Time.time-startTime)<31)
            {
                animator.SetInteger("Executioner", 0);
            }
            else if((Time.time-startTime)>31 & (Time.time-startTime)<40)
            {
                rot.y=-90;
                animator.SetInteger("Executioner", 1);
            }

            else if((Time.time-startTime)>40 & (Time.time-startTime)<58)
            {
                rot.y=-180;
                animator.SetInteger("Executioner", 2);
            }

            else if((Time.time-startTime)>58 & (Time.time-startTime)<69)
            {
                rot.y=-90;
                animator.SetInteger("Executioner", 3);
            }
            else if((Time.time-startTime)>69)
            {
                rot.y=-180;
                animator.SetInteger("Executioner", 4);
            }

            transform.eulerAngles=rot;
        }
    }
}
