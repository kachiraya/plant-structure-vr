﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class VRInteractiveItem : MonoBehaviour {

	public event Action OnOver;             // Called when the gaze moves over this object
	public event Action OnOut;              // Called when the gaze leaves this object
	public event Action OnClick;            // Called when click input is detected whilst the gaze is over this object.
	public event Action OnDoubleClick;      // Called when double click input is detected whilst the gaze is over this object.
	public event Action OnUp;               // Called when Fire1 is released whilst the gaze is over this object.
	public event Action OnDown;             // Called when Fire1 is pressed whilst the gaze is over this object.


	protected bool m_IsOver;


	public bool IsOver
	{
		get { return m_IsOver; }              // Is the gaze currently over this object?
	}


	// The below functions are called by the VREyeRaycaster when the appropriate input is detected.
	// They in turn call the appropriate events should they have subscribers.
	public void Over()
	{
		m_IsOver = true;

		if (OnOver != null)
			OnOver();
	}


	public void Out()
	{
		m_IsOver = false;

		if (OnOut != null)
			OnOut();
	}


	public void Click()
	{
		if (OnClick != null)
			OnClick();
	}

	public void Up()
	{
		if (OnUp != null)
			OnUp();
	}


	public void Down()
	{
		if (OnDown != null)
			OnDown();
	}


//	//	//subscribe to an event
//	void OnEnable() {
//		VRInput.OnClick += TreeSelect;
//	}
//
//	//unsubscribe the event
//	void OnDisable() {
//		EventManager.OnClicked -= TreeSelect;
//	}
//
//	void TreeSelect() {
//		Debug.Log ("Select Tree!!!");
//	}
//
//
//	public bool IsOver
//	{
//		get { return m_IsOver; }              // Is the gaze currently over this object?
//	}
}
