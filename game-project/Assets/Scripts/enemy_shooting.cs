using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_shooting : MonoBehaviour {

    public Transform shootPoint;
    public GameObject enemy_bullet;
    public int counter = 60;
	public int counter_value = 60;
    public Transform player;
    public enemy_movement enemyMovement;
    // Update is called once per frame

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player").transform;
    }

    void Update () {
        float distance = Vector3.Distance(player.transform.position, transform.position);
        counter--;
        if(counter <= 0)
        {
            if (enemyMovement.distance <= enemyMovement.huntingRange)
            {
                Shoot();
            }
            counter = counter_value;
        }                             
            
	}

    
    
    //This function creates a bullet object
    void Shoot()
    {
    	GameObject clone;

        clone = Instantiate(enemy_bullet, shootPoint.position, shootPoint.rotation) as GameObject;

    }
}
