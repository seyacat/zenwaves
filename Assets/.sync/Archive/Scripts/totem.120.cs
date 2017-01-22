using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class totem : MonoBehaviour {
	public float amplitud = 0.01f;
	public float longitud = 0.3f;
	public float velocidad = -0.3f;
	public float damp = 15.0f;
	public float ds=0;
	public Boolean ishover=false;




	// Use this for initialization
	void Start () {
		amplitud = 0.03f;
		longitud = 0.3f;
	}

	// Update is called once per frame
	void Update () {
		 
		ds = ds + velocidad;
		while (amplitud <1 && amplitud >= 0.04 && ishover==false){
			amplitud -= 0.01f;
		}
	
	}
	void  OnMouseEnter(){
		if (ishover == false) {
			ishover = true;
		}

	}
	void OnMouseExit(){
		ishover = false;
	}
	void OnMouseDown (){
		if (ishover == true) {
			//Debug.Log ("tocaste");
			if(amplitud>=0 && amplitud <1 && ishover == true ){
				amplitud += 0.05f;
			}


		

		}
	}




}
