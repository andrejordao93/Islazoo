using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandeler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

	public static GameObject itemBeingDragged;
	public Vector3 startPosition;

	void Update(){

	}

	public void OnBeginDrag(PointerEventData eventData){

		itemBeingDragged = gameObject;
		startPosition = transform.position;
		//Debug.Log ("OnBeingDrag called");
	}

	public void OnDrag(PointerEventData eventData){

		transform.position = Input.mousePosition;
		//Debug.Log ("OnDrag called");
	}

	public void OnEndDrag(PointerEventData eventData){

		itemBeingDragged = null;
		transform.position = startPosition;
		//Debug.Log ("OnEndDrag called");
	}
}
