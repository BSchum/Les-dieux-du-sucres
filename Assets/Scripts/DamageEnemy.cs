using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class DamageEnemy : NetworkBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1") && isLocalPlayer)
        {
            Ray r = new Ray(this.transform.position, this.transform.forward);
            RaycastHit rhit;
            if (Physics.Raycast(r, out rhit))
            {
                if(rhit.collider.gameObject.layer == LayerMask.NameToLayer("Enemy"))
                {
                    CmdKillEnemy(rhit.collider.gameObject);
                }
            }
            
        }	
	}

    [Command]
    void CmdKillEnemy(GameObject go)
    {
        go.GetComponent<Health>().TakeDamage(10);
    }
}
