using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class splashFadeout : MonoBehaviour {
    public CanvasGroup cv;
	// Use this for initialization
	void Start () {
        StartCoroutine(fadeout());
	}
    IEnumerator fadeout() {
        yield  return new WaitForSeconds(3);
        DOTween.To(() => cv.alpha, x =>cv.alpha = x, 0, 2);

    }
    // Update is called once per frame
    void Update () {
		
	}
}
