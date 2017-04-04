using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour {

	Camera camera;

	// Use this for initialization
	void Start () {
		camera = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDrag(){
		transform.position = (Vector2) camera.ScreenToWorldPoint (Input.mousePosition);
	}
}
