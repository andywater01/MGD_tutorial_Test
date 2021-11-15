using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class mobileControls : MonoBehaviour
{
    public float speed;
    public Joystick joystick;
    public Rigidbody rb;
    public GameObject cam;
    public JoyButton jb;
    bool dataset = false;

    public PhotonView view;

    public void FixedUpdate()
    {
        if (dataset)
        {
           
                Vector3 direction = cam.transform.forward * joystick.Vertical + cam.transform.right * joystick.Horizontal;
                rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
            
            ////else
            //{
            //    rb.velocity = new Vector3(0.0f, 0.0f, 0.0f);
            //}
        }
       
            
        
    }

    public void SetJoystick(GameObject go)
    {
        Joystick[] joys = go.GetComponentsInChildren<Joystick>();
        foreach (Joystick joy in joys)
        {
            if (joy.name == "Look Joystick")
                joystick = joy;
        }
        dataset = true;
    }

    public void SetCamera(GameObject cameraa)
    {
        cam = cameraa;
    }
}
