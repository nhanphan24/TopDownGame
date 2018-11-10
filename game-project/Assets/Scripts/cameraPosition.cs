using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cameraPosition : MonoBehaviour {

    public Transform player;
    private float zoomSize = 5;
    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(player.position.x, player.position.y, -10f);
        Zoom();
	}

    void Zoom()
    {
        float scrollWheel = Input.GetAxis("Mouse ScrollWheel");
        if (scrollWheel > 0 && zoomSize > 2)
        {
            zoomSize -= 0.5f;
        }

        if (scrollWheel < 0 && zoomSize < 14)
        {
            zoomSize += 0.5f;
        }
        GetComponent<Camera>().orthographicSize = zoomSize;
    }
}
