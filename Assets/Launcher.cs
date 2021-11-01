using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;


public class Launcher : MonoBehaviourPunCallbacks
{
    public InputField createInput;
    public InputField joinInput;
    public Text error;
    
    string errorInfo = "Error!";

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Connecting");
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected");
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        Debug.Log("Joined Main Lobby");
    }

    public void CreateRoom()
    {
        if (string.IsNullOrEmpty(createInput.text))
            return;
        PhotonNetwork.CreateRoom(createInput.text);
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinInput.text);
    }

    public override void OnJoinedRoom()
    {

    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        error.text = errorInfo;
        
        Debug.Log("Error creating room!");
    }
}

