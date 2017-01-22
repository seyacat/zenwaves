using UnityEngine;
using System.Collections;
using DG.Tweening;
using UnityEngine.UI;

public class End_area : MonoBehaviour {

	public int wintime=0;
    public bool boladentro = false;
    public MeshRenderer cutoutRenderer;
    public GameObject LevelWinObject;
    public GameObject LevelLoseObject;
    public Funciones funciones;
    int timeLimit = 60;
    public Text timeText;
    bool endlevel = false;


	void Start () {
        LevelWinObject.SetActive(false);
        LevelLoseObject.SetActive(false);
        StartCoroutine(tic());
    }

    IEnumerator tic() {
        yield return new WaitForSeconds(1);
        timeLimit = Mathf.Clamp(timeLimit - 1, 0, 60);
        if (timeLimit == 0) {
                LevelLoseObject.SetActive(true);
             funciones.changeDelayedNextScene(3);
             }
        timeText.text = "" + timeLimit;
        StartCoroutine(tic());
    }
	// Update is called once per frame
	void FixedUpdate () {
        if (boladentro)
        {
            wintime++;
            
        }
        float cutvalue = Mathf.Clamp(((200f - wintime) / 300f), 0.001f, 1);       
        cutoutRenderer.material.SetFloat("_Cutoff", cutvalue);
        if (cutvalue == 0.001f)
        {
            LevelWinObject.SetActive(true);
            funciones.changeDelayedNextScene(3);
            //Destroy(this);
        }
    }

	void OnTriggerEnter(Collider other){
        boladentro = true;
		}
			
	void OnTriggerExit(){
        boladentro = false;

	}
}
