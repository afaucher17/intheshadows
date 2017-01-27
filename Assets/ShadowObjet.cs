using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ShadowObjet : MonoBehaviour {

	public bool horizontalMovement;
	public bool verticalMovement;
	public bool moveable;

	public float moveSpeed = 1.0f;
	public float rotationSpeed = 1.0f;

	void OnMouseDrag() {
		var mouse_x = Input.GetAxis ("Mouse X");
		var mouse_y = Input.GetAxis ("Mouse Y");

		Debug.Log (mouse_x + " " + mouse_y);
		if (mouse_x != 0 && mouse_y != 0) {
			if (moveable && (Input.GetKey (KeyCode.LeftShift) || Input.GetKey (KeyCode.RightShift))) {
				this.transform.position += new Vector3 (mouse_x, mouse_y, 0) * moveSpeed * Time.deltaTime;
			} else if (verticalMovement && (Input.GetKey (KeyCode.LeftControl) || Input.GetKey (KeyCode.RightControl))) {
				this.transform.Rotate(Camera.main.transform.up, -mouse_x * rotationSpeed * Time.deltaTime, Space.World);
			} else if (horizontalMovement) {
				this.transform.Rotate (Camera.main.transform.forward, -mouse_y * rotationSpeed * Time.deltaTime, Space.World);
			}
		}
	}

	// Use this for initialization
	void Start () {
			
	}
	
	// Update is called once per frame
	void Update () {
	}
}
