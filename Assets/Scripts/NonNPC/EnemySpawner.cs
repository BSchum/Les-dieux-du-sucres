using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class EnemySpawner : NetworkBehaviour {

    public GameObject enemyPrefab;
    public int enemiesNumber;

    public override void OnStartServer()
    {
        for(int i = 0; i < enemiesNumber; i++)
        {
            GameObject enemy = Instantiate(enemyPrefab, new Vector3(0, 1, 0), Quaternion.identity);
            NetworkServer.Spawn(enemy);
        }
    }
}
