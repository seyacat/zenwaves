﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class totem : MonoBehaviour {
	public float amplitud = 0.1f;
	public float longitud = 0.1f;
	public float velocidad = -0.3f;
	public float damp = 0.0f;
	public float ds=0;
	public Boolean ishover=false;
	public Camera main_camera;

	public  float  number = 0.0f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		 
		ds = ds + velocidad;
		while (amplitud <=1 && amplitud >= 0.2  && ishover==false){
			amplitud -= 0.1f;
		}
		camera ();
	}
	void OnMouseOver(){
		if (ishover == false) {
			ishover = true;
		}

	}
	void OnMouseDown (){
		if (ishover == true) {
			Debug.Log ("tocaste");
			if(amplitud>=0 && amplitud <1 && ishover == true ){
				amplitud += 0.1f;
			}

			ishover = false;
		

		}
	}
	void  camera(){
		const int orthographicSizeMin = 1;
		const int orthographicSizeMax = 6;
		if (Input.GetAxis("Mouse ScrollWheel") > 0) // forward
		{
			number =Camera.main.orthographicSize++;
		}
		if (Input.GetAxis("Mouse ScrollWheel") < 0) // back
		{
			number = Camera.main.orthographicSize--;
		}
		Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize, orthographicSizeMin, orthographicSizeMax );
		//number = Input.GetAxis("Mouse ScrollWheel");
		//Camera.main.orthographicSize += number;

	}



}
