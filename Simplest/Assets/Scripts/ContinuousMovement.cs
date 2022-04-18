using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;

public class ContinuousMovement : MonoBehaviour
{
    public float speed=1;
    public XRNode inputSource;
    public float gravity=-9.81f;
    public LayerMask groundLayer;
    public float additionalHeight=0.2f;

    private float fallingSpeed;
    private XRRig rig;
    private Vector2 inputAxis;
    private CharacterController character;

    public bool startCountdown=false;
    public bool dofChange=false;
    //public Vector3 savedRotation;

    // Start is called before the first frame update
    void Start()
    {
        character=GetComponent<CharacterController>();
        rig=GetComponent<XRRig>();
    }

    // Update is called once per frame
    /*
    void Update()
    {
        
        InputDevice device=InputDevices.GetDeviceAtXRNode(inputSource);
        device.TryGetFeatureValue(CommonUsages.primary2DAxis, out inputAxis);
        
       
    }
 */

    private void FixedUpdate()
    {

        var freedom=GameObject.Find("Guard").GetComponent<BotMovement>().freeMovement;
        if(freedom)
        {
            InputDevice device=InputDevices.GetDeviceAtXRNode(inputSource);
            device.TryGetFeatureValue(CommonUsages.primary2DAxis, out inputAxis);
            CapsuleFollowHeadset();

            Quaternion headYaw=Quaternion.Euler(0,rig.cameraGameObject.transform.eulerAngles.y,0);
            Vector3 direction=headYaw*new Vector3(inputAxis.x,0,inputAxis.y);
            character.Move(direction*Time.fixedDeltaTime*speed);

            bool isGrounded=CheckIfGrounded();
            if (isGrounded)
                fallingSpeed=0;
            else
                fallingSpeed+=gravity*Time.fixedDeltaTime;


            character.Move(Vector3.up*fallingSpeed*Time.fixedDeltaTime);
        }
        else
        {
            dofChange=true;
            var pos = transform.position;
            if(pos.x>2.6f & pos.y<0.3f)
            {
                pos.x-=0.6f*Time.deltaTime;
            }
            else if(pos.z<-11.0f)
            {
                pos.z+=0.6f*Time.deltaTime;
            }
            else if (pos.z<-10.3f)
            {
                pos.z+=0.3f*Time.deltaTime;
                pos.y+=0.45f*Time.deltaTime;
            }
            /*else if(pos.z<-9.85f)
            {
                pos.z+=0.6f*Time.deltaTime;
            }*/
            else if(pos.x<3.5f)
            {
                pos.x+=0.6f*Time.deltaTime;
            }
            else
            {
                pos.x=3.5066f;
                pos.z=-10.29816f;
                startCountdown=true; // starts the process of the hood being drawn over your head
                //savedRotation=GameObject.Find("VR Camera").transform.eulerAngles;
                //PlayerPrefs.SetFloat("x",savedRotation.x);
                //PlayerPrefs.SetFloat("y",savedRotation.y);
                //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            }
            transform.position = pos;
// (3.5066,1.049999,-10.29816)
        }

    }

    void CapsuleFollowHeadset()
    {
        character.height=rig.cameraInRigSpaceHeight+additionalHeight;
        Vector3 capsuleCenter=transform.InverseTransformPoint(rig.cameraGameObject.transform.position);
        character.center=new Vector3(capsuleCenter.x,character.height/2+character.skinWidth,capsuleCenter.z);
    }

    bool CheckIfGrounded()
    {
        Vector3 rayStart=transform.TransformPoint(character.center);
        float rayLength=character.center.y+0.01f;
        bool hasHit=Physics.SphereCast(rayStart,character.radius,Vector3.down,out RaycastHit hitInfo, rayLength, groundLayer);
        return hasHit;
    }
}
