using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxcollider : MonoBehaviour {
    public Rigidbody2D box;
	// Use this for initialization
	void Start () {
        box = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

   
}
