using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WardenScript : MonoBehaviour
{
    Animator animator;
    public float startTime=0f;
    public float speed;

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

                if (timePassed>20)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
                }
            }
    }
}
