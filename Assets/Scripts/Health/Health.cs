using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Health : NetworkBehaviour{
    public int maxHealth;
    [SyncVar]
    public int health;
    public void TakeDamage(int amount)
    {
        if (!isServer)
        {
            return;
        }
        health -= amount;

        if(health <= 0)
        {
            Network.Destroy(this.gameObject);
            Destroy(this.gameObject);
        }
    }
    

}
