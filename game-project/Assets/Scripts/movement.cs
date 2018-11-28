using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
 
    public float speed = 5f;     
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

        Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}

