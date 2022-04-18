using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneConnection : MonoBehaviour
{
    public float plx;
    public float ply;
    // Start is called before the first frame update
    void Start()
    {
        plx=PlayerPrefs.GetFloat("x");
        ply=PlayerPrefs.GetFloat("y");
        var rot = transform.eulerAngles;
        rot.x=plx;
        rot.y=ply;
        transform.eulerAngles=rot;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(ply);
        Debug.Log(plx);
        //Debug.Log(ContinuousMovement.savedRotation);
    }
}
