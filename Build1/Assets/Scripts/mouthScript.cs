using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mouthScript : MonoBehaviour {
	GameObject[]  sceneObjs ;

	int difficulty = 0;
	float[] pullSpeed = {30.00f, 50.00f, 70.00f};
	float[] pushSpeed = {100.00f, 100.00f, 100.00f};

	int fliesEaten;
	int fliesTotal;

	public Text flyUI;
	public Text flyTotalUI;

	public Camera camera;

	// Use this for initialization
	void Start () {
		sceneObjs = GameObject.FindGameObjectsWithTag("Fly");
		//pullSpeed = 30.00f;
		//pushSpeed = 300.00f;
		fliesEaten = 0;
		fliesTotal = 5;
		flyTotalUI.text = "/ "+fliesTotal.ToString();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {

			Vector3 realMousePosition = camera.ScreenToWorldPoint(Input.mousePosition);
			//print (realMousePosition);
			foreach (GameObject obj in sceneObjs) {
				if (obj != null) {
					//print (obj.transform.position);

					Vector2 push = obj.transform.position - realMousePosition;
					push.Normalize();
					obj.GetComponent<Rigidbody2D> ().AddForce (push * pushSpeed[difficulty]);
				}
			}
		}

		foreach(GameObject obj in sceneObjs){
			if (obj != null) {
				Vector2 pull = transform.position- obj.transform.position;
				obj.GetComponent<Rigidbody2D> ().AddForce (pull* pullSpeed[difficulty] * Time.deltaTime);
				//obj.transform.position = Vector2.MoveTowards (obj.transform.position, transform.position, pullSpeed * Time.deltaTime);
			}
		}
	}
		

	void OnTriggerEnter2D(Collider2D other){
		GameObject hit = other.gameObject;
		if(hit.tag == "Fly"){
			Destroy(hit);
			fliesEaten++;
			flyUI.text = fliesEaten.ToString();
		}
	}

	public void difficulty0(){
		//Application.LoadLevel(Application.loadedLevel);
		difficulty = 0;
	}


	public void difficulty1(){
		//Application.LoadLevel(Application.loadedLevel);
		difficulty = 1;
	}


	public void difficulty2(){
		//Application.LoadLevel(Application.loadedLevel);
		difficulty = 2;
	}

}
