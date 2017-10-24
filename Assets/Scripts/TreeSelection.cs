using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class TreeSelection : MonoBehaviour {
	//VRInteractiveItem interactible = hit.collider.GetComponent<VRInteractiveItem>();    //attempt to get the VRInteractiveItem on the hit object
	//[SerializeField] private Material m_NormalMaterial;                
	//[SerializeField] private Material m_OverMaterial;                  
	//[SerializeField] private Material m_ClickedMaterial;               
	//[SerializeField] private Material m_DoubleClickedMaterial; 
	//[SerializeField] private Renderer m_Renderer;

	public GameObject notiCanvas;
	public bool isSeen;

	[SerializeField] private VRInteractiveItem m_InteractiveItem;
	[SerializeField] private Transform m_Camera;

	private string nameToDisplay;
	private NotiCanvasHandler notiCanvasHandler;
	private Component halo;
	private string[] treeNames = {"ต้นข้าวโพด", "ต้นมะม่วง", "ต้นเข็ม", "ต้นกล้วย", "ต้นปาล์ม", "ต้นพริก", "ดอกชบา", "ต้นมะขาม"};

	void Start() {
		notiCanvasHandler = notiCanvas.GetComponent<NotiCanvasHandler> ();
		halo = GetComponent("Halo");
	}

	private void OnEnable()
	{
		m_InteractiveItem.OnOver += HandleOver;
		m_InteractiveItem.OnOut += HandleOut;
		m_InteractiveItem.OnClick += HandleClick;
		m_InteractiveItem.OnDoubleClick += HandleDoubleClick;
	}


	private void OnDisable()
	{
		m_InteractiveItem.OnOver -= HandleOver;
		m_InteractiveItem.OnOut -= HandleOut;
		m_InteractiveItem.OnClick -= HandleClick;
		m_InteractiveItem.OnDoubleClick -= HandleDoubleClick;
	}


	//Handle the Over event
	private void HandleOver()
	{
		if (Math.Sqrt (Math.Pow (m_Camera.position.x - this.transform.position.x, 2.00) +
		    Math.Pow (m_Camera.position.y - this.transform.position.y, 2.00) +
		    Math.Pow (m_Camera.position.z - this.transform.position.z, 2.00)) < 30) {
			//m_Renderer.material = m_OverMaterial;
			Debug.Log ("Show over state " + this.name);
			halo.GetType().GetProperty("enabled").SetValue(halo, true, null);
			int index = int.Parse ("" + this.name.ToCharArray () [this.name.Length - 1]) - 1;
			nameToDisplay = treeNames [index];

			notiCanvasHandler.SetTextName(nameToDisplay);
			notiCanvasHandler.SetPanelDisplayActive(true);
		}
		//m_Renderer.material.shader = Shader.Find("Outlined/Silhouetted Diffuse");
	}


	//Handle the Out event
	private void HandleOut()
	{
		//Debug.Log("Show out state");
		//m_Renderer.material = m_NormalMaterial;
		//m_Renderer.material.shader = Shader.Find("Diffuse");
		halo.GetType().GetProperty("enabled").SetValue(halo, false, null);
		nameToDisplay = "";
		notiCanvasHandler.SetTextName(nameToDisplay);
		notiCanvasHandler.SetPanelDisplayActive(false);
	}


	//Handle the Click event
	private void HandleClick()
	{
		Debug.Log("Show click state");


		if (!notiCanvasHandler.isClicked) {
			CameraHandler camHandlerScript = m_Camera.GetComponent<CameraHandler>();
			camHandlerScript.AnimationFalse ();
			notiCanvasHandler.SetPanelInfoActive (true);
		}

//		m_Renderer.material = m_ClickedMaterial;
//		if (canvas.gameObject.activeSelf && isClicked) {
//			Debug.Log ("Bleh");
//			canvas.gameObject.SetActive (false);
//		} else if(!isClicked) {
//			canvas.gameObject.SetActive (true);
//			float distX = m_Camera.position.x - this.transform.position.x;
//			//float distY = m_Camera.position.y - this.transform.position.y;
//			float distZ = m_Camera.position.z - this.transform.position.z;
//
//			CameraHandler camHandlerScript = m_Camera.GetComponent<CameraHandler>();
//			camHandlerScript.AnimationFalse ();
//			//canvas.gameObject.transform.position = new Vector3(m_Camera.position.x + distX/2+2, m_Camera.position.y, m_Camera.position.z + distZ/2+2);
//		}


	}
		

	//Handle the DoubleClick event
	private void HandleDoubleClick()
	{
		Debug.Log("Show double click");
		//m_Renderer.material = m_DoubleClickedMaterial;
	}

////	//subscribe to an event
//	void OnEnable() {
//		m_VrInput.OnClick += TreeSelect;
//	}
//
//	//unsubscribe the event
//	void OnDisable() {
//		m_VrInput.OnClick -= TreeSelect;
//	}
//
//	void TreeSelect() {
//		//VRInteractiveItem interactible = hit.collider.GetComponent<VRInteractiveItem>();    //attempt to get the VRInteractiveItem on the hit object
//		Debug.Log ("Select Tree!!!");
//	}

//	void Update() {
//		Debug.Log ("Bleh!!!");
//		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//		RaycastHit hit;
//
//		if (Physics.Raycast(ray, out hit, 100))
//			Debug.DrawLine(ray.origin, hit.point);
//	}
}
