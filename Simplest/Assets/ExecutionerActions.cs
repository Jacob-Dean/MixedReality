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
            else if((Time.time-startTime)>21 & (Time.time-startTime)<30)
            {
                rot.y=-90;
                animator.SetInteger("Executioner", 1);
            }

            else if((Time.time-startTime)>31 & (Time.time-startTime)<51)
            {
                rot.y=-180;
                animator.SetInteger("Executioner", 2);
            }

            else if((Time.time-startTime)>51 & (Time.time-startTime)<62)
            {
                rot.y=-90;
                animator.SetInteger("Executioner", 3);
            }
            else if((Time.time-startTime)>62)
            {
                rot.y=-180;
                animator.SetInteger("Executioner", 4);
            }

            transform.eulerAngles=rot;
        }
    }
}
