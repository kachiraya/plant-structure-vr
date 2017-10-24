using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotiCanvasHandler : MonoBehaviour {
	
	public GameObject panelDisplay;
	public GameObject textName;
	public GameObject panelInfo;

	public bool isClicked = false;

	public void SetTextName(string str) {
		textName.GetComponent<UnityEngine.UI.Text>().text = str;
	} 

	public void SetPanelDisplayActive(bool boolean) {
		panelDisplay.SetActive (boolean);
	}

	public void SetPanelInfoActive(bool boolean) {
		isClicked = boolean;
		panelInfo.SetActive (boolean);
	}
}
