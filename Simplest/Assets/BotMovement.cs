using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class BotMovement : MonoBehaviour
{
    Animator animator;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        animator=GetComponent<Animator>();

        //FindObjectOfType<AudioManager>().Play("one");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(speed);
        var pos = transform.position;
        var rot = transform.eulerAngles; // Capture position and rotational vectors so that we can change the components

        if(Time.realtimeSinceStartup>10 & Time.realtimeSinceStartup<=14)
        // BEWARE!!!! Making distance travelled conditional on time can be problematic
        // This is because if you have a lower framerate, you will travel less distance
        
        {
            animator.SetBool("Walking", true); // After 15 seconds, the guard starts walking

            pos.z-=speed*Time.deltaTime;
            transform.position = pos;
        }
        else if(Time.realtimeSinceStartup>14 & Time.realtimeSinceStartup<=25)
        {
            animator.SetBool("Walking", false); // After 15 seconds, the guard starts walking
        }
        else if(Time.realtimeSinceStartup>25 & Time.realtimeSinceStartup<=29)
        {
            animator.SetBool("Walking", true); // After 15 seconds, the guard starts walking

            rot.y=0f;
            pos.z+=speed*Time.deltaTime;
        }
        else if(Time.realtimeSinceStartup>29)
        {
            if(pos.x>-1.28 & pos.z>-9) // first constraint controls the movement and second part of the constraint ensures that only one part of the conditional is triggered
            {
                rot.y=-90f;
                pos.x-=speed*Time.deltaTime;
            }
            else if(pos.z>-21.2 & pos.x<2)
            {
                rot.y=-180f;
                pos.z-=speed*Time.deltaTime;
            }
            else if(pos.x<5.1 & pos.z<-16)
            {
                rot.y=-270f;
                pos.x+=speed*Time.deltaTime;
            }
            else
            {
                if(pos.z<-19.8)
                {
                    rot.y=0f;
                    pos.z+=speed*Time.deltaTime;
                }
                else if(pos.z<-16) // Walking down the stairs
                {
                    pos.z+=speed*Time.deltaTime;
                    pos.y-=0.6f*speed*Time.deltaTime;
                }
                else if(pos.z<-11)
                {
                    pos.z+=speed*Time.deltaTime;
                }
                else
                {
                    rot.y=-180f;
                    animator.SetBool("Walking", false);
                }
  
            }
        }


            
/*
            if(pos.x>=-1.28)
            {
                pos.x -=0.02f;
            }

            else if(pos.x<-1.28)
            {

                rot.y=-180f;
                pos.z-=0.02f;
            }
*/
        transform.position = pos;
        transform.eulerAngles=rot;
        


        // z-:0, x+:-90, z+:-180, x-:-270
            //transform.position=new Vector3(0.31f,2.49f,-21.71f);
            //Debug.Log(transform.position.y);


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
