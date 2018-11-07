using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_bulletMovement : MonoBehaviour {

    public float bulletSpeed = 10f;
    public Rigidbody2D enemy_bullet;

	// Use this for initialization
	void Start () {
        //This function tells the bullet to move depends
        //on the speed given by variable bulletSpeed from
        //the moment the bullet is created
        enemy_bullet.velocity = transform.right * bulletSpeed;
        GetComponent<SpriteRenderer>().sortingLayerName = "projectile";

    }

    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.name == "player")
        {
           	Destroy(other.gameObject);
           	Destroy(gameObject);
           	//Debug.Log("OnCollisionEnter2D");
        }

        if (other.gameObject.name == "background")
        {
          // Debug.Log(gameObject);
            Destroy(gameObject);
        }


    }

}
