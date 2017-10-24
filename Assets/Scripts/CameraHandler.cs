using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHandler : MonoBehaviour {

	public Animator animator;
	public NotiCanvasHandler notiCanvasHandler;

	void Start () {
		animator = GetComponent<Animator>();
	}   

	public void AnimationFalse() {
		animator.enabled = false;
	}


	//Update is called once per frame
	void Update() {
		if (!animator.enabled) {
			//key or mouse click detected
			if (Input.anyKey || Input.anyKeyDown) {
				animator.enabled = true;
//				treeSelectScript.CloseCanvas ();
				Debug.Log("CLicked or Keydown");
				//GameObject.Find("InfoCanvas").SetActive(false);
				notiCanvasHandler.SetPanelInfoActive(false);
			}

		}

	}


//	// Use this for initialization
//	void Start () {
//		
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		
//	}


}
