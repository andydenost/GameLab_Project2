using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateT : MonoBehaviour {
	public GameObject[] tr = new GameObject[3];

	// Use this for initialization
	void Start () {
		Vector3[] v = new Vector3 [3];
		for(int i = 0;i<3;i++){
			v [i] = new Vector3 (Random.Range(-4.5f,4.5f),0.5f,Random.Range(-4.5f,4.5f));
			tr[i].transform.position = v [i];
			Instantiate (tr[i]);
		}
	}
	
	// Update is called once per frame
	void Update () {
  		
	}
}
