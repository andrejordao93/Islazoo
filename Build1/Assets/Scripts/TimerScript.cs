using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour {
	float timer;
	public Text gameEnd;
	public Text flyUI;
	public Text flyTotalUI;

	// Use this for initialization
	void Start () {
		timer = 10.00f;
		gameEnd.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		gameObject.GetComponent<Text>().text = "00:"+Mathf.FloorToInt(timer).ToString();

		if (timer <= 0) {
			Time.timeScale = 0;
			if (int.Parse (flyUI.text) == int.Parse (flyTotalUI.text.Substring (1))) {
				gameEnd.text = "Failure";
			} else {
				gameEnd.text = "Success";
			}
			gameEnd.enabled = true;
		}
	}
}
