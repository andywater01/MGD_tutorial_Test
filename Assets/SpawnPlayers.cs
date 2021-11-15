using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject cameraPrefab; //*
    new GameObject camera;

    public float minX, maxX;
    public float minZ, maxZ;

    void Start()
    {
        Vector3 randomPosition = new Vector3(Random.Range(minX, maxX), 0f, Random.Range(minZ, maxZ));
        //PhotonNetwork.Instantiate(playerPrefab.name, randomPosition, Quaternion.identity);
        camera = Instantiate(cameraPrefab, randomPosition, Quaternion.identity);

        GameObject player = PhotonNetwork.Instantiate(playerPrefab.name, randomPosition, Quaternion.identity);

        if (player.GetComponent<PhotonView>().IsMine)
        {
            //player.GetComponent<PlayerController>().SetJoysticks(Instantiate(cameraPrefab, randomPosition, Quaternion.identity));
            player.GetComponent<mobileRotation>().SetJoystick(camera);
            player.GetComponent<mobileControls>().SetJoystick(camera);
            player.GetComponent<mobileControls>().SetCamera(camera.GetComponentInChildren<Camera>().gameObject);

            camera.GetComponentInChildren<Camera>().gameObject.GetComponent<TransformFollower>().SetTarget(player);
        }
            
    }


}
