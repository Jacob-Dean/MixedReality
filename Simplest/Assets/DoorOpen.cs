using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{

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
        if(Time.time>90)
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
