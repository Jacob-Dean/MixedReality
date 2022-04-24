using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class SnapConstrictor : MonoBehaviour
{
    SnapTurnProvider snap;
    // Start is called before the first frame update
    void Start()
    {
        snap=GetComponent<SnapTurnProvider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("VR Rig").GetComponent<ContinuousMovement>().dofChange)
        {
            snap.turnAmount=0;
        }
        //driver.trackingType=TrackedPoseDriver.TrackingType.RotationOnly;
    }
}
