using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameController : MonoBehaviour {

	public GameObject[] animalButtomImage;
	public GameObject[] animalImage;
	public static string animalRandom;
	public static int animalNumber;
	public Text message;
	public Text question;
	private int value = 5;
	public Button girafa;
	public Button macaco;
	public Button papagaio;
	public Button pinguim;
	public Button toupeira;
	public Button mocho;

	// Use this for initialization
	void Start () {
		hideImage ();
		randomSelectAnimal ();
		message.text = "";
		question.text = "";
	}

	void Update () {

	}

	void hideImage(){
		for(int i = 0; i <= value; i++){
			animalButtomImage [i].SetActive (false);
		}
	}

	void randomSelectAnimal(){
		animalNumber = Random.Range (0,5);
		animalButtomImage [animalNumber].SetActive (true);
		animalRandom = animalButtomImage [animalNumber].tag;
		Invoke ("hideRandomImage", 2);
	}

	void hideRandomImage(){
		animalButtomImage [animalNumber].SetActive (false);
		question.text = "Qual foi o Animal que apareceu?";
	}

	public void clickGirafaButton(){
		if (girafa.tag == animalRandom) {
			question.text = "CORRECT";
		} else {
			question.text = "INCORRECT";
		}
	}

	public void clickMacacoButton(){
		if (macaco.tag == animalRandom) {
			question.text = "CORRECT";
		} else {
			question.text = "INCORRECT";
		}
	}

	public void clickPapagaioButton(){
		if (papagaio.tag == animalRandom) {
			question.text = "CORRECT";
		} else {
			question.text = "INCORRECT";
		}
	}

	public void clickPinguimButton(){
		if (pinguim.tag == animalRandom) {
			question.text = "CORRECT";
		} else {
			question.text = "INCORRECT";
		}
	}

	public void clickMochoButton(){
		if (mocho.tag == animalRandom) {
			question.text = "CORRECT";
		} else {
			question.text = "INCORRECT";
		}
	}

	public void clickToupeiraButton(){
		if (toupeira.tag == animalRandom) {
			question.text = "CORRECT";
		} else {
			question.text = "INCORRECT";
		}
	}
}
