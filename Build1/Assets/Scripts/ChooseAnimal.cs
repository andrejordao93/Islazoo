using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseAnimal : MonoBehaviour {

	public GameObject[] animalImage;
	public GameObject[] animalBlackImage;
	public static string animalRandom;
	public Text message;
	private int value = 5;

	// Use this for initialization
	void Start () {
		hideBlackImage ();
		randomSelectAnimal ();
		message.text = "";
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit)) {

				if (animalRandom == hit.collider.tag) {
					//StartCoroutine (showMessage ("Certo", 2));
					message.text = "CERTO";
					//Debug.Log ("ACERTOU");
				} else {
					message.text = "ERRADO";
					//Debug.Log ("ERROU");
				}
			}
		}
	}

//	IEnumerable showMessage (string message, float delay){
//		//guiText
//	}

	void hideBlackImage(){
		for(int i = 0; i <= value; i++){
			animalBlackImage [i].SetActive (false);
		}
	}

	void randomSelectAnimal(){
		int animalNumber = Random.Range (0,5);
		animalBlackImage [animalNumber].SetActive (true);
		//Instantiate (animalBlackImage[animalNumber], transform.position, transform.rotation);
		animalRandom = animalBlackImage [animalNumber].tag;
		Debug.Log (animalRandom);
	}
}
