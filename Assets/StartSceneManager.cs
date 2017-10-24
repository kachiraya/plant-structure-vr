using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSceneManager : MonoBehaviour {

	public GameObject startCanvas;
	// Use this for initialization
	void Start () {
		Time.timeScale = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKey || Input.anyKeyDown) {
			startCanvas.SetActive (false);
			Time.timeScale = 1.0f;
//			StartCoroutine (StartFade ());
		}
	}

//	IEnumerator StartFade() {
//		float fadeTime = GetComponent<Fader>().BeginFade (1);
//		yield return new WaitForSeconds (fadeTime);
//	}
}
