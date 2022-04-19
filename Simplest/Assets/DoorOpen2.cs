 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen2 : MonoBehaviour
{
    public float startTime=0f;
    Animator animator;
    public bool playSound=true;
    // Start is called before the first frame update
    void Start()
    {
        animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (startTime==0)
        {
            startTime=Time.time;
        }
        var timePassed=Time.time-startTime;

        if(timePassed>25)
        {
            animator.SetBool("Open", true);
            if (playSound==true)
            {
                FindObjectOfType<AudioManager>().Play("Door");
                playSound=false;
            }
        }
    }
}
