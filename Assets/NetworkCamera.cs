using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
[RequireComponent(typeof(Camera))]
public class NetworkCamera : MonoBehaviour {
    Camera cam;
	// Use this for initialization
	void Start () {
        Camera cam = GetComponent<Camera>();
        NetworkIdentity netidentity = GetComponentInParent<NetworkIdentity>();
        if (!netidentity.isLocalPlayer)
        {
            cam.enabled = false;
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
