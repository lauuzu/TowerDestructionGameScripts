using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaudymasUniver : MonoBehaviour {

	public Rigidbody bulletPrefab;
	public Transform firePosition;
	public float bulletspeed;
	private Inventorius inventory;
	public Camera fpsCam;
	public float damage = 10f;
	public int ShotMade = 0;
	void Awake () {
		inventory = GetComponent<Inventorius> ();
	}
	void Start()
	{
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			Shoot ();
			PlayerPrefs.SetInt ("Saudymas", ShotMade);
		}
	}
	void Shoot(){
			ShotMade++;
			Rigidbody bulletInstance = Instantiate (bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody;
			bulletInstance.AddForce (firePosition.forward * bulletspeed);
			AudioSource audio = GetComponent<AudioSource> ();
			audio.Play ();
			RaycastHit hit;
			Ray ray = new Ray (firePosition.position, firePosition.forward);
		if (Physics.Raycast (ray, out hit, 100f)) {
			Debug.Log (hit.transform.name);
			Laimejimas target = hit.transform.GetComponent<Laimejimas> ();
			Target target1 = hit.transform.GetComponent<Target> ();
			if (target != null) {
				target.TakeDamage (damage);
			}
			if (target1 != null) {
				target1.TakeDamage (damage);
			}
			if (hit.rigidbody != null) {
				hit.rigidbody.AddForce (-hit.normal * 500f);
			}
		}
			//inventory.Mystuff.bullets--;
		
		}
	}
