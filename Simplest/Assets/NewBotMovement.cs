using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBotMovement : MonoBehaviour
{
    Animator animator;
    public float speed;
    public float startTime=0f;
    // Start is called before the first frame update
    void Start()
    {
        animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;
        var rot = transform.eulerAngles;

        if (startTime==0)
        {
            startTime=Time.time;
        }
        var timePassed=Time.time-startTime;
        
        if(timePassed>10 & timePassed<=14)
        // BEWARE!!!! Making distance travelled conditional on time can be problematic
        // This is because if you have a lower framerate, you will travel less distance
        
        {
            animator.SetBool("Walking", true); // After 15 seconds, the guard starts walking

            pos.z-=speed*Time.deltaTime;
            transform.position = pos;
        }
        else if(Time.time>14 & Time.time<=25)
        {
            animator.SetBool("Walking", false); // After 15 seconds, the guard starts walking
        }
    }
}
