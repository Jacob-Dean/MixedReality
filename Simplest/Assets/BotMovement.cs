using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class BotMovement : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator=GetComponent<Animator>();

        //FindObjectOfType<AudioManager>().Play("one");
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.realtimeSinceStartup>30)
        {
            animator.SetBool("Walking", true); // After 15 seconds, the guard starts walking

            var pos = transform.position;
            var rot = transform.eulerAngles; // Capture position and rotational vectors so that we can change the components


            if(pos.x>=-1.28)
            {
                pos.x -=0.02f;
            }

            else if(pos.x<-1.28)
            {

                rot.y=-180f;
                pos.z-=0.02f;
            }

            transform.position = pos;
            transform.eulerAngles=rot;


            //transform.position=new Vector3(0.31f,2.49f,-21.71f);
            //Debug.Log(transform.position.y);


        }

        //Debug.Log(Math.Sqrt(4));
        //Debug.Log(GameObject.Find("VR Rig").transform.position);
        // Debug.Log(Time.realtimeSinceStartup);

        /*
        points
        (-1.28,2.505,-3.91)
        (-1.28,2.505,-10.31)
        (0.61,2.505,-21.3)
        */
    }
}
