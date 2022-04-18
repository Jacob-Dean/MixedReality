using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class Enforcement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;

        var xval=GameObject.Find("Guard").transform.position.x;
        var zval=GameObject.Find("Guard").transform.position.z;

        var rot=GameObject.Find("Guard").transform.eulerAngles;

        var proximity=Math.Sqrt(Math.Pow(pos.x-xval,2)+Math.Pow(pos.z-zval,2));

        //Debug.Log(proximity);
        if(proximity>2 & Time.time>30 & GameObject.Find("Guard").GetComponent<BotMovement>().freeMovement)
        {
            // YOU CAN MAKE THIS CODE WAY CLEANER - YOU CAN JUST
            // RESET THE WHOLE VECTOR TO THE POSITION VECTOR OF THE GUARD
            // AND THEN YOU DON't NEED to get copies of the vectors

            
            if(rot.y==0)
            {
                pos.z=zval-1.0f;
                pos.x=xval;
            }
            else if(rot.y==270)
            {
                pos.x=xval+1.0f;
                pos.z=zval;
            }
            else if(rot.y==180)
            {
                pos.z=zval+1.0f;
                pos.x=xval;
            }
            else if(rot.y==90)
            {
                pos.x=xval-1.0f;
                pos.z=zval;
            }
            

            transform.position = pos;

        }
        //Debug.Log(proximity);
    }
}
