using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mobileRotation : MonoBehaviour
{
    public Joystick joystick;
    public JoyButton joybutton;
    public Rigidbody rigidbody;
    bool dataset = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dataset)
        {
            
             gameObject.transform.localRotation = gameObject.transform.localRotation * Quaternion.AngleAxis(joystick.Horizontal * 1, Vector3.up);
            
        }
        
    }

    public void SetJoystick(GameObject go)
    {
        Joystick[] joys = go.GetComponentsInChildren<Joystick>();
        foreach (Joystick joy in joys)
        {
            if (joy.name == "Move Joystick")
                joystick = joy;
        }
        dataset = true;
    }
}
