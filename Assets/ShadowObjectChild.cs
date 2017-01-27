using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowObjectChild : MonoBehaviour {
	void OnMouseDrag() {
		this.transform.parent.SendMessage ("OnMouseDrag");
	}
		
	void OnMouseDown() {
		this.transform.parent.SendMessage ("OnMouseDown");
	}

	void OnMouseUp() {
		this.transform.parent.SendMessage ("OnMouseUp");
	}
}
