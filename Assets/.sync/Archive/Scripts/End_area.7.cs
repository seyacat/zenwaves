using UnityEngine;
using System.Collections;

public class End_area : MonoBehaviour {

	public GameObject win_text;
	public GameObject piedra;
	// Use this for initialization
	void Start () {
		win_text.GetComponent<CanvasRenderer>().SetAlpha(0);	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){
		if(other.tag=="Piedra"){
			win_text.GetComponent<CanvasRenderer>().SetAlpha(1);
		}
		
	}
}
