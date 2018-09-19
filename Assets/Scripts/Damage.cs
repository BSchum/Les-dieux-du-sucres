using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour {
    int damage = 1;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Collider[] players = Physics.OverlapSphere(this.transform.position, 100);
        
        foreach (Collider player in players)
        {
            if(player.gameObject.layer == 8)
                player.GetComponent<Health>().TakeDamage(damage);
        }
    }
}
