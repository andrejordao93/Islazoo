using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MailmanScript : MonoBehaviour {

	public int waypointCount;
	public GameObject waypoints;
	public Text gameEnd;
	// Use this for initialization
	void Start () {
		waypointCount = 0;
		gameEnd.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector2.MoveTowards (transform.position, waypoints.transform.GetChild(waypointCount).transform.position , 5.00f*Time.deltaTime);

		if(waypointCount == waypoints.transform.childCount-1){
			gameEnd.text = "Success";
			gameEnd.enabled = true;
		}

		if(Vector2.Distance(transform.position, waypoints.transform.GetChild(waypointCount).transform.position) < 0.01f && waypointCount != waypoints.transform.childCount-1){
			waypointCount++;
		}

	}

	void OnCollisionEnter2D(Collision2D other){
		Time.timeScale = 0;
		gameEnd.enabled = true;
	}
		
}
