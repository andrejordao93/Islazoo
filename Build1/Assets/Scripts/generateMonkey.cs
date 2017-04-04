using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class generateMonkey : MonoBehaviour {

	public Text question;
	public GameObject[] place;
	public GameObject macaco;
	public int value;
	public static int animalNumberPlace = 0;
	public float doubleClickStart = 0;

	// Use this for initialization
	void Start () {
		hide();
		question.text = "FAZ DOUBLE CLICK NO MACACO";
		chooseRandomPlace ();
		Invoke ("loseGame", 20.0f);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (Time.time - doubleClickStart < 0.4) {
				if(Physics.Raycast(ray, out hit)){	
					if(macaco.tag == hit.collider.tag){
						Debug.Log ("ACERTASTE");
						Application.LoadLevel ("win");
					}
				}
				doubleClickStart = -1;
			} else {
				doubleClickStart = Time.time;
			}
		}
	}

	void hide(){
		for (int i = 0; i <= value; i++) {
			place [i].SetActive (false);
		}
	}

	void chooseRandomPlace(){
		place [animalNumberPlace].SetActive (false);
		animalNumberPlace = Random.Range (0,19);
		place [animalNumberPlace].SetActive (true);
		Invoke ("chooseRandomPlace", 0.9f);
		//Debug.Log (place [animalNumberPlace]);
	}

	void loseGame(){
		Application.LoadLevel ("lose");
	}
}
