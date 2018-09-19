using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(NetworkIdentity))]
public class PlayerMove : MonoBehaviour {

    public MotorBase motor;
    InputHandler ih;
    NetworkIdentity netIdentity;

    // Use this for initialization
    void Start () {
        motor = new Motor(this.gameObject);
        //Choose wich InputHandler we should use ( pc or controller)
        InputHandlerBuilder ihb = new InputHandlerBuilder();
        ih = ihb.ChooseInputHandler().Build();
    }

    // Update is called once per frame
    void Update () {        
        //Move with ih vector
        motor.Move(ih.ComputeMovement(), ih.ComputeRotation());
    }
}
