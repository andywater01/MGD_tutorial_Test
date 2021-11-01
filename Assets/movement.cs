using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class movement : MonoBehaviour
{
    public Transform player;
    public Rigidbody rb;
    public Transform cam;

    public void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            player.transform.Translate(Vector3.forward * 10 * Time.deltaTime);
            //rb.AddForce(Vector3.forward.normalized * 10f, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.S))
        {
            player.transform.Translate(Vector3.forward * -10 * Time.deltaTime);
            //rb.AddForce(Vector3.forward.normalized * 10f, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.D))
        {
            player.transform.Translate(Vector3.right * 10 * Time.deltaTime);
            //rb.AddForce(Vector3.forward.normalized * 10f, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.A))
        {
            player.transform.Translate(Vector3.left * 10 * Time.deltaTime);
            //rb.AddForce(Vector3.forward.normalized * 10f, ForceMode.VelocityChange);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            rb.AddForce(Vector3.up.normalized * 10f, ForceMode.Impulse);
        }
    }

    private void LateUpdate()
    {
        player.localRotation = Quaternion.Euler(new Vector3(0, cam.rotation.eulerAngles.y, 0));
    }
}
