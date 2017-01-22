using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using DG.Tweening;

public class totem : MonoBehaviour {
	public float amplitud = 0.0f;
	public float longitud = 1f;
	public float velocidad = -0.3f;
	public float damp = 15.0f;
	public float ds=0;
	public Boolean encendido=false;
	public Boolean ishover=false;
	public float amplitud_default=0.0f;




	// Use this for initialization
	void Start () {
		
		//longitud = 0.3f;
		amplitud_default=amplitud;
		amplitud = 0.0f;
	}

	// Update is called once per frame
	void Update () {
		if (this.tag == "Totem_repulsivo") {
			velocidad = -0.3f;
		} else {
			velocidad = 0.3f;
		}
		ds = ds + velocidad;
		while (amplitud <0.13 && amplitud >= 0.04 && ishover==false){
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
		encendido = !encendido;
		DOTween.To (() => amplitud, x => amplitud = x,amplitud_default, 1);
	}
	void OnMouseDown (){
		// Tween a Vector3 called myVector to 3,4,8 in 1 second

			if (encendido) {
				encendido = !encendido;
				DOTween.To (() => amplitud, x => amplitud = x, 1, 1);
			} else {
				encendido = !encendido;
				DOTween.To (() => amplitud, x => amplitud = x, amplitud_default, 1);
			}
			/*if (ishover == true) {
				//Debug.Log ("tocaste");
				if(amplitud>=0 && amplitud <0.13 && ishover == true ){
					amplitud += 0.05f;
				}*/


			

			}
	}





