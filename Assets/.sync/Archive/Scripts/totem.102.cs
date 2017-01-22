using System.Collections;
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



	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		 
		ds = ds + velocidad;
		while (amplitud <=1 && amplitud >= 0.2  && ishover==false){
			amplitud -= 0.1f;
		}
	
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

			if(){
				ishover = false;}
		

		}
	}




}
