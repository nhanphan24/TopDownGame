using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class enemy_movement : MonoBehaviour {

	public Vector2 move;
	public Rigidbody2D enemy;
	public int speed = 5;
	public int counter = 20;
	public int counter_value = 20;
	// Use this for initialization
	
	// Update is called once per frame
	

	void Start(){
		
	}

	void Update () {
		counter--;
		if(counter <= 0){
			Vector2 move = new Vector2(Random.Range(-1f, 1f)*speed, Random.Range(-1f, 1f)*speed);
			enemy.velocity = move;
			counter = counter_value*speed;
		}
	}
}
