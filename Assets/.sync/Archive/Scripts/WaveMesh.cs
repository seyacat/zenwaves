using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveMesh : MonoBehaviour {


	Mesh mesh;
	private Vector3[] verts;

	public GameObject[] totem;

	// Use this for initialization
	void Start () {
		for (var j = 0; j < totem.Length; j++) {
			if (totem [j].GetComponent<totem> () == null) {
				totem [j].AddComponent<totem> ();
				}
			}
		mesh = gameObject.GetComponent<MeshFilter>().mesh;

	}
	
	// Update is called once per frame
	void Update () {
		float tx ;
		float tz ;
		float dist;
		float longitud;
		float amplitud;
		float velocidad;
		float damp;
		float ds;

		if (verts == null)
			verts = mesh.vertices;

		var vertices = new Vector3[verts.Length];
		for (var i=0;i<vertices.Length;i++)
		{
			var vertex = verts[i];
			for (var j = 0; j < totem.Length; j++) {
				tx = totem[j].transform.position.x;
				tz = totem[j].transform.position.z;
				longitud = totem [j].GetComponent<totem> ().longitud;
				amplitud = totem [j].GetComponent<totem> ().amplitud;
				velocidad = totem [j].GetComponent<totem> ().velocidad;
				damp = totem [j].GetComponent<totem> ().damp;
				ds = totem [j].GetComponent<totem> ().ds ;

				dist = Mathf.Sqrt (Mathf.Pow (tx - vertex.x, 2) + Mathf.Pow (tz - vertex.z, 2)) / longitud;

				vertex.y += Mathf.Sin (ds + dist) * (amplitud-Mathf.Clamp(amplitud*damp*dist,0,amplitud));
				}
			vertex.y += Mathf.PerlinNoise(baseHeight[i].x , baseHeight[i].y + Mathf.Sin(Time.time * 0.1f)    ) * noiseStrength;
			vertices[i] = vertex;
		}
		mesh.vertices = vertices;
		mesh.RecalculateNormals();
		gameObject.GetComponent<MeshCollider> ().sharedMesh = mesh;
	}
}
