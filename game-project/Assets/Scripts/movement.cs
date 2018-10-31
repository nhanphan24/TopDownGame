using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    // These variables are for the movement of the player
    // movement. Public variable speed lets us adjust how
    // fast we want our player to move
    public float moveHorizontal; 
    public float moveVertical;   
    public float speed = 10f;     
    public Rigidbody2D player;
    private Vector2 move;

    // Facing stores the direction that the player is facing
    private string Facing = "Right";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        moveHorizontal = Input.GetAxisRaw("Horizontal") * speed;
        moveVertical = Input.GetAxisRaw("Vertical") * speed;
        move = new Vector2(moveHorizontal, moveVertical);
        player.velocity = move;

        // Set the angle of the player to face the direction 
        // that the player is moving in
        if (moveHorizontal > 0 && Facing != "Right")
        {
            Facing = "Right";
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }

        if (moveHorizontal < 0 && Facing != "Left")
        {
            Facing = "Left";
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }

        if (moveVertical > 0 && Facing != "Up")
        {
            Facing = "Up";
            transform.rotation = Quaternion.Euler(0f, 0f, 90f);
        }

        if (moveVertical < 0 && Facing != "Down")
        {
            Facing = "Down";
            transform.rotation = Quaternion.Euler(180f, 0f, 90f);
        }
    }
}

