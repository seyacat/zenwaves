using UnityEngine;
using System.Collections;

public class End_area : MonoBehaviour {

	public GameObject win_text;
	public GameObject piedra;
	// Use this for initialization
	void Start () {
		piedra=GameObject.FindGameObjectWithTag("Piedra");
		win_text.GetComponent<CanvasRenderer>().SetAlpha(0);	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){
		if(other.tag=="Piedra"){
			win_text.GetComponent<CanvasRenderer>().SetAlpha(1);
			piedra.transform.position = this.transform.position;
		}
		
	}
}
