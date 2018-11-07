using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_shooting : MonoBehaviour {

    public Transform shootPoint;
    public GameObject enemy_bullet;
    public int counter = 60;
	public int counter_value = 60;
	// Update is called once per frame
	void Update () {
        // If "Fire2" is pressed down, then call the function Shoot  
        counter--;
        if(counter <= 0)
        {
        	Shoot();
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
