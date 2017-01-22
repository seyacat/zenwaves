using UnityEngine;
using System.Collections;
using DG.Tweening;
using UnityEngine.UI;

public class End_area : MonoBehaviour {

	public GameObject text;
	public GameObject piedra;
	public Vector3 ubication=new Vector3(0,0,0);
	public bool win=false;
	public int time=5;
	public GameObject luz;
	// Use this for initialization
	void Start () {
		piedra=GameObject.FindGameObjectWithTag("Piedra");
		text.GetComponent<CanvasRenderer>().SetAlpha(0);	
	}

	// Update is called once per frame
	void Update () {
		if (time == 0) {
			
			PlayerPrefs.SetString ("mensaje", "Haz Ganado");
			text.GetComponent<CanvasRenderer> ().SetAlpha (1);
			piedra.transform.position = this.transform.position;
			win = true;
		}
		if (win == true) {
			piedra.transform.position = this.transform.position;
			Instantiate(luz);
			luz.transform.position=this.transform.position;

		}
	}
	void OnTriggerEnter(Collider other){
		

			if (other.tag == "Piedra") {
				DOTween.To (() => time, x => time = x, 0, 3);
		}
			
		
		
	}
	void OnTriggerExit(){
			
			DOTween.To (() => time, x => time = x, 5, 2);



	}
}
