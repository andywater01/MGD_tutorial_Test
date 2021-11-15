using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public GameObject player;
    Vector3 offset = new Vector3(0, 0, -10);
 

    // Update is called once per frame
    void Update()
    {
        this.transform.localPosition = player.transform.localPosition + offset;

        this.transform.rotation = player.transform.rotation;
    }
}
