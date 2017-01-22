using UnityEngine;
using System.Collections;
using DG.Tweening;

public class End_area : MonoBehaviour {

	public GameObject win_text;
	public GameObject piedra;
	public Vector3 ubication=new Vector3(0,0,0);
	public bool win=false;
	public float time=5.0f;
	// Use this for initialization
	void Start () {
		piedra=GameObject.FindGameObjectWithTag("Piedra");
		win_text.GetComponent<CanvasRenderer>().SetAlpha(0);	
	}

	// Update is called once per frame
	void Update () {
		if (win == true) {
			piedra.transform.position = this.transform.position;
		}
	}
	void OnTriggerEnter(Collider other){
		DOTween.To (() => time, x => time = x, 0, 2);
		if (time <= 0) {
			if (other.tag == "Piedra") {
				win_text.GetComponent<CanvasRenderer> ().SetAlpha (1);
				piedra.transform.position = this.transform.position;
				win = true;
			}
		}
		
	}
}
