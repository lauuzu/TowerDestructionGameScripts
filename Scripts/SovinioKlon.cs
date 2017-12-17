using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SovinioKlon : MonoBehaviour {
	public Rigidbody bulletPrefab; // obejktas kuri spawnisim , kulka
	public Transform firePosition; // tuscias Objektas kur spawnisim, kulkos spawn siuo atveju
	// Use this for initialization
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			Rigidbody bulletInstance;
			bulletInstance = Instantiate (bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody; // koks objektas pasirodys kur ir kaip
			bulletInstance.AddForce(firePosition.forward * 5000); // musa per kulka smugio jega wuhuuhuhuhu
		}
		
	}
}
