using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScript : MonoBehaviour {
    public Funciones funciones;
	// Use this for initialization
	void Start () {
        funciones.changeDelayedScene("Inicio",5);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
