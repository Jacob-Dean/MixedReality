using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SpatialTracking;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class PleaseWork2 : MonoBehaviour
{
    TrackedPoseDriver driver;
    // Start is called before the first frame update
    void Start()
    {
        driver=GetComponent<TrackedPoseDriver>();
    }

    // Update is called once per frame
    void Update()
    {
        var pos=GameObject.Find("VR Rig").GetComponent<Transform>().position;

        if (pos.z>-2.5)
        {
            GameObject.Find("Left Hand").transform.localScale=new Vector3(0,0,0);
            GameObject.Find("Right Hand").transform.localScale=new Vector3(0,0,0);
            //Debug.Log(lscale);
        }


        //Debug.Log(driver.trackingType);
    }

}
