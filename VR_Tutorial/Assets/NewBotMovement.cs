using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBotMovement : MonoBehaviour
{
    Animator animator;
    public float speed;
    public float startTime=0f;
    public bool playSound=true;
    // Start is called before the first frame update
    void Start()
    {
        animator=GetComponent<Animator>();
        FindObjectOfType<AudioManager>().Play("Indoor");
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
        
        if(timePassed>25 & timePassed<29)
        // BEWARE!!!! Making distance travelled conditional on time can be problematic
        // This is because if you have a lower framerate, you will travel less distance
        
        {

            animator.SetBool("Walking", true); // After 15 seconds, the guard starts walking

            pos.z-=speed*Time.deltaTime;

        }
        else if(timePassed>29 & timePassed<31)
        {

            rot.y=-90;
            pos.x-=speed*Time.deltaTime;
        }
        else if(timePassed>31 & timePassed<=40)
        {

            rot.y=-180;
            animator.SetBool("Walking", false); // After 15 seconds, the guard starts walking
            if (playSound==true)
            {
                FindObjectOfType<AudioManager>().Play("Lee6");
                playSound=false;
            }
        }
        transform.position = pos;
        transform.eulerAngles = rot;
    }
}
