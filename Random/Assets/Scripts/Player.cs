using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float moveSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			this.transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
		}else if (Input.GetKey (KeyCode.A)) {
			this.transform.Translate (Vector3.left * moveSpeed * Time.deltaTime);
		}else if (Input.GetKey (KeyCode.D)) {
			this.transform.Translate (Vector3.right * moveSpeed * Time.deltaTime);
		}else if (Input.GetKey (KeyCode.S)) {
			this.transform.Translate (Vector3.back * moveSpeed * Time.deltaTime);
		}
	}

}
