using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    // These variables are for the movement of the player
    // movement. Public variable speed lets us adjust how
    // fast we want our player to move
 
    public float speed = 10f;     
    public Rigidbody2D player;
  

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float moveHorizontal = Input.GetAxisRaw("Horizontal") * speed;
        float moveVertical = Input.GetAxisRaw("Vertical") * speed;
        Vector2 move = new Vector2(moveHorizontal, moveVertical);
        player.velocity = move;

        // Set the angle of the player to face the direction 
        // that the player is moving in
        Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}

