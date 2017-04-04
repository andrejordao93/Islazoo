using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuScript : MonoBehaviour {

	public void Game1 () {
		Application.LoadLevel("bocejo");
	}

	public void Game2 () {
		Application.LoadLevel("jaguar");
	}

	public void Game3 () {
		Application.LoadLevel("prototipo");
	}

	public void Game4 () {
		Application.LoadLevel("labirinto");
	}

	public void Game5 () {
		Application.LoadLevel("guessImage");
	}

	public void Game6 () {
		Application.LoadLevel("findMonkey");
	}
}