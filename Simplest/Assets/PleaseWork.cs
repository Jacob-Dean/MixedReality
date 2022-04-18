using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SpatialTracking;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class PleaseWork : MonoBehaviour
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
        if(GameObject.Find("VR Rig").GetComponent<ContinuousMovement>().dofChange)
        {
            Debug.Log(2);
            driver.trackingType=TrackedPoseDriver.TrackingType.RotationOnly;
            GameObject.Find("Left Hand").transform.localScale=new Vector3(0,0,0);
            GameObject.Find("Right Hand").transform.localScale=new Vector3(0,0,0);
            //Debug.Log(lscale);
        }


        //Debug.Log(driver.trackingType);
    }

}

