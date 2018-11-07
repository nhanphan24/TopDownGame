﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour {

    public Transform shootingPoint;
    public GameObject bullet;
	// Update is called once per frame
	void Update () {
        // If "Fire2" is pressed down, then call the function Shoot
        if (Input.GetKey(KeyCode.Mouse0)) 
        {                                 
            Shoot();
            Debug.Log(KeyCode.Mouse0);
        }
	}

    
    
    //This function creates a bullet object
    void Shoot()
    {
        Instantiate(bullet, shootingPoint.position, shootingPoint.rotation);
    }
}
