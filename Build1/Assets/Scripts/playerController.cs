using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	float myAccelarationX = 0.0f;
	float myAccelarationY = 0.0f;
	float smoothSpeed = 3.5f;
	float lockPos = 0;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		move();
	}

	void move(){
		var x = Mathf.Lerp(myAccelarationX, Input.acceleration.x, smoothSpeed * Time.deltaTime);
		var y = Mathf.Lerp(myAccelarationY, Input.acceleration.y, smoothSpeed * Time.deltaTime);

		transform.Translate (x, y, 0);
		transform.rotation = Quaternion.Euler (transform.rotation.eulerAngles.x, lockPos, lockPos);
	}
}
