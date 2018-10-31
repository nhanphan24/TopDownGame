using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMovement : MonoBehaviour {

    public float bulletSpeed = 15f;
    public Rigidbody2D bullet;

	// Use this for initialization
	void Start () {
        //This function tells the bullet to move depends
        //on the speed given by variable bulletSpeed from
        //the moment the bullet is created
        bullet.velocity = transform.right * bulletSpeed;
	}

}
