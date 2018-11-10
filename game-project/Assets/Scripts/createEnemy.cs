using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createEnemy : MonoBehaviour {

    public GameObject enemy;
    public Transform spawnPoint;
    public int spawnCycle = 250;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        spawnCycle++;
        if (spawnCycle >= 300)
        {
            CreateEnemy();
            spawnCycle = 0;
        }
	}

    void CreateEnemy()
    {
        Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
    }
}
