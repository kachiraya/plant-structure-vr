using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotiCanvasHandler : MonoBehaviour {
	
	public GameObject panelDisplay;
	public GameObject textName;
	public GameObject panelInfo;
	public GameObject treeInfoImage;

	public bool isClicked = false;
	public bool isFirstInfo = false;

	private int currentIndex = -1;


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

	public void SetFirstInfoImage(int index) {
		isFirstInfo = true;
		currentIndex = index;
		Image image = treeInfoImage.GetComponent<Image> ();
		image.sprite = Resources.Load<Sprite> ("treeinfo/tree-" + (index+1) + "_" + 1);
	}

	public void SetSecondInfoImage() {
		isFirstInfo = false;
		Image image = treeInfoImage.GetComponent<Image> ();
		image.sprite = Resources.Load<Sprite> ("treeinfo/tree-" + (currentIndex+1) + "_" + 2);
	}
}
