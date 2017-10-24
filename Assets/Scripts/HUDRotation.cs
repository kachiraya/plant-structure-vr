using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDRotation : MonoBehaviour {

	[SerializeField] private Transform m_Camera;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var m_Camera = transform.parent.GetComponentInChildren<Camera> ();
		var projectedLookDirection = Vector3.ProjectOnPlane (m_Camera.transform.forward, Vector3.up);
		transform.rotation = Quaternion.LookRotation (projectedLookDirection);

	}
}
