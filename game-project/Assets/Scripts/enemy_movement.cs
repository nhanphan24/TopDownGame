using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class enemy_movement : MonoBehaviour {

	public Rigidbody2D enemy;
	public int speed = 5;
	public int counter = 20;
	public int counter_value = 20;
    public Transform player;
    public float huntingRange = 20f;
    public float distance;
    // Use this for initialization

    // Update is called once per frame


    void Start(){
        player = GameObject.FindGameObjectWithTag("player").transform;
	}

	void Update () {
		counter--;
        distance = Vector3.Distance(player.transform.position, transform.position);
        if (distance > huntingRange)
        {
            if (counter <= 0)
            {
                Vector2 move = new Vector2(Random.Range(-1f, 1f) * speed, Random.Range(-1f, 1f) * speed);
                enemy.velocity = move;
                counter = counter_value * speed;
            }
        }

        else
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            Vector3 direction = player.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }

}
