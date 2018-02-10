using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dig : MonoBehaviour {

	float gold;
	float blue;
	float white;
	public GameObject g;
	public GameObject b;
	public GameObject w;
	bool hasClicked;


	void Start(){
		gold = 5.0f;
		blue = 35.0f;
		white = 100.0f;
		hasClicked = false;
	}

	public void dig(){
		
		if(hasClicked == false){
			float[] rand = new float[3];
			float tempx = -2;
			for(int i=0;i<3;i++){
				tempx++; 
				rand[i] = Random.Range (0.0f,100.0f);
				if(rand[i]<gold){
					g.transform.position  = new Vector3(tempx, g.transform.position.y, g.transform.position.z);
					Instantiate (g);
					Debug.Log ("gold");
				}else if(rand[i]<blue){
					b.transform.position  = new Vector3(tempx, b.transform.position.y, b.transform.position.z);
					Instantiate (b);
					Debug.Log ("blue");
				}else{
					w.transform.position  = new Vector3(tempx, w.transform.position.y, w.transform.position.z);
					Instantiate (w);
					Debug.Log ("white");
				}
			}
		}
		hasClicked = true;
	}
}
