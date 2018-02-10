using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Encounter : MonoBehaviour {

	// Use this for initialization
	float p;
	public int stepNum;
	Vector3 lastPos;
	void Start () {
		p = 0.0f;
		stepNum = 0;
		lastPos = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if(Vector3.Distance(lastPos,this.transform.position)>=1.0f){
			stepNum++;
			Debug.Log ("stepNum"+stepNum);
			p=p+1.475f;
			float rand = Random.Range (0.0f,100.0f);
			if(rand<p){
				SceneManager.LoadScene ("Dig");
			}
			lastPos = this.transform.position;
		}
}
}
