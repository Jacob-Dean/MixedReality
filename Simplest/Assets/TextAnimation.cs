using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextAnimation : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        var pos=GameObject.Find("VR Rig").GetComponent<Transform>().position;

        if (pos.z>-5)
        {
            animator.SetBool("FreeTrigger",true);
        }
        /*
        if(Time.time>25)
        {
            animator.SetBool("Open", true);
        }
        */   
    }
}
