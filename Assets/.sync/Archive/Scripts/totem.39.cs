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
	Boolean ishover=false;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		ds = ds + velocidad;
		while (amplitud >=1 && ishover==false){
			amplitud -=1
		}
	}
	void OnMouseOver(){
		ishover = true;

	}
	void OnMouseDown (){
		if (ishover == true) {
			Debug.Log ("tocaste");
			while(amplitud>=0 && amplitud <1 && ishover == true ){
				amplitud += 0.1f;
			}

			ishover = false;
		

		}
	}



}
