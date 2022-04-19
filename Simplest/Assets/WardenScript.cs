using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WardenScript : MonoBehaviour
{
    Animator animator;
    public float startTime=0f;
    public float speed;
    public bool playSound=true;

    // Start is called before the first frame update
    void Start()
    {
        animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("Hood").GetComponent<HoodTrigger>().wardenTrigger)
            {
                if (playSound==true)
                {
                    FindObjectOfType<AudioManager>().Play("Lee5");
                    playSound=false;
                }
                
                if (startTime==0)
                {
                    startTime=Time.time;
                }
                var timePassed=Time.time-startTime;

                var pos = transform.position;
                var rot = transform.eulerAngles;

                if(pos.x<3.5)
                {
                    animator.SetInteger("Warden", 1);
                    pos.x+=0.6f*Time.deltaTime;
                }
                else
                {
                    animator.SetInteger("Warden", 2);
                    rot.y=180;
                }
                transform.position = pos;
                transform.eulerAngles = rot;

                if (timePassed>30 & timePassed<32)
                {
                    animator.SetInteger("Warden", 3);
                }
                else if(timePassed>32)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
                }
            }
    }
}
// (1.972,2.64,-5.95) 180