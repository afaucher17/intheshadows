using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowObjet : MonoBehaviour {

	public bool horizontalMovement;
	public bool verticalMovement;
	public bool moveable;

	public float moveSpeed = 1.0f;
	public float rotationSpeed = 1.0f;

	private Vector3? _mousePosition = null;

	void OnMouseDown() {
		_mousePosition = Input.mousePosition;
	}

	void OnMouseDrag() {
		if (_mousePosition != null && _mousePosition.GetValueOrDefault() != Input.mousePosition) {
			var heading = Input.mousePosition - _mousePosition.GetValueOrDefault();
			var distance = heading.magnitude;
			var direction = heading / distance;

			Debug.Log (this.transform.rotation);
			if (moveable && (Input.GetKey (KeyCode.LeftShift) || Input.GetKey (KeyCode.RightShift))) {
				Debug.Log ("Move");
				this.transform.position += heading * moveSpeed * Time.deltaTime;
			} else if (verticalMovement && (Input.GetKey (KeyCode.LeftControl) || Input.GetKey (KeyCode.RightControl))) {
				Debug.Log ("VerticalRotation");
				this.transform.Rotate (new Vector3 (0, 0, direction.x) * rotationSpeed * Time.deltaTime);
			} else if (horizontalMovement) {
				Debug.Log ("HorizontalRotation");
				this.transform.Rotate (new Vector3 (0, direction.y, 0) * rotationSpeed * Time.deltaTime);
			}
		}
		_mousePosition = Input.mousePosition;
	}

	void OnMouseUp() {
		_mousePosition = null;
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}
}
