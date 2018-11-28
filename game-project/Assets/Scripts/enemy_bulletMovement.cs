using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_bulletMovement : MonoBehaviour {

    private float bulletSpeed = 15f;
    public Rigidbody2D enemy_bullet;

	// Use this for initialization
	void Start () {
        enemy_bullet.velocity = transform.right * bulletSpeed;
        GetComponent<SpriteRenderer>().sortingLayerName = "projectile";

    }

    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.name == "player")
        {
           	Destroy(other.gameObject);
           	Destroy(gameObject);
        }

        if (other.gameObject.name == "background")
        {
            Destroy(gameObject);
        }


    }

}
