﻿using UnityEngine;
using System.Collections;

public class UnitychanPose : MonoBehaviour {

	private Animator anim;
	private int animCount = 0;
	private string animName = "POSE01";
	public float fadeTime = 3;
	
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnGUI()
	{
		if ( GUI.Button( new Rect(10, 40, 100, 20), animName ) )
		{
			animCount = (animCount + 1) % 31;
			animName = string.Format("POSE{0:00}", animCount + 1);
			anim.CrossFade(animName, fadeTime);
		}
	}
}