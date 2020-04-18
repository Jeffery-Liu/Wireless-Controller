using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine.Networking.NetworkSystem;
using UnityEngine;

public class NetworkClientUI : MonoBehaviour {

    static NetworkClient client;
    string stringToEdit = "192.168.1.70";
    void OnGUI()
    {
        string ipaddress = Network.player.ipAddress;
        GUI.Box(new Rect(10, Screen.height - 50, 100, 50), ipaddress);
        GUI.Label(new Rect(20, Screen.height - 30, 100, 20), "Status:" + client.isConnected);

        if(!client.isConnected)
        {
            // x, y, width, height
            stringToEdit = GUI.TextField(new Rect(960, 540, 400, 50), stringToEdit, 25);
            if (GUI.Button(new Rect(980, 680, 180, 150), "Enter"))
            //if (GUI.Button(new Rect(100, 100, 150, 150), "Enter"))
            {
                //Debug.Log("Enter pressed!");
                inputConnect();
            }

            if (GUI.Button(new Rect(10, 10, 160, 150), "Connect"))
            {
                Connect();
            }

        }
        if (GUI.Button(new Rect(10, 200, 160, 150), "Disconnect"))
        {
            Disconnect();
        }
    }
	// Use this for initialization
	void Start () {
        client = new NetworkClient();
	}

    void Connect()
    {
        client.Connect("192.168.1.64", 25000);
    }

    void inputConnect()
    {
        client.Connect(stringToEdit, 25000);
    }

    void Disconnect()
    {
        client.Disconnect();
    }

    static public void SendJoystickInfo(float hDelta, float vDelta)
    {
        if(client.isConnected)
        {
            StringMessage msg = new StringMessage();
            msg.value = hDelta + "|" + vDelta;
            client.Send(888, msg);
        }
    }

	// Update is called once per frame
	void Update () {
		
	}
}
