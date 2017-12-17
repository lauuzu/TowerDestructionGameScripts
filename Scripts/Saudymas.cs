using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saudymas : MonoBehaviour {
	public GameObject Kulka;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			Instantiate (Kulka, transform.position, transform.rotation);
		}
	}
}
