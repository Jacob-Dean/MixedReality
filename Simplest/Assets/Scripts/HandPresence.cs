using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HandPresence : MonoBehaviour
{
    //public bool showController=false;

    public GameObject handModelPrefab;
    private GameObject spawnedHandModel;
    private Animator handAnimator;
    //private InputDevice targetDevice;

    public XRNode inputSource;

    // Start is called before the first frame update
    void Start()
    {
        //List<InputDevice> devices=new List<InputDevice>();

        //InputDevices.GetDevices(devices);
        //targetDevice=devices[0];
        //Debug.Log(targetDevice.name+targetDevice.characteristics);
        /*foreach(var item in devices)
        {
            Debug.Log(item.name + item.characteristics);
        }*/

        spawnedHandModel=Instantiate(handModelPrefab,transform);
        handAnimator=spawnedHandModel.GetComponent<Animator>();
    }



    // Update is called once per frame
    void Update()
    {
        InputDevice device=InputDevices.GetDeviceAtXRNode(inputSource);

        spawnedHandModel.SetActive(true);

        if(device.TryGetFeatureValue(CommonUsages.trigger,out float triggerValue))
        {
            handAnimator.SetFloat("Trigger",triggerValue);
        }
        else
        {
            handAnimator.SetFloat("Trigger",0);
        }

        if(device.TryGetFeatureValue(CommonUsages.grip,out float gripValue))
        {
            handAnimator.SetFloat("Grip",gripValue);
        }
        else
        {
            handAnimator.SetFloat("Grip",0);
        }
        /*if(showController)
        {
            spawnedHandModel.SetActive(false);
            spawnedController.SetActive(true);
        }
        else
        {
            spawnedHandModel.SetActive(true);
            spawnedController.SetActive(false);
        }
        */
    }
}
