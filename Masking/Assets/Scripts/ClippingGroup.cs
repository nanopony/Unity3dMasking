using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClippingGroup : MonoBehaviour {
	public int ClippingGroupId = 1;

	public void OnValidate() {
		_updateClippingGroup();
	}


	private void _updateClippingGroup() {
		var r = GetComponent<Renderer> ();
		r.material.SetInt ("_ClippingGroup", ClippingGroupId);
	}

	// Use this for initialization
	void Start () {
		
	}


	// Update is called once per frame
	void Update () {
		
	}
}
