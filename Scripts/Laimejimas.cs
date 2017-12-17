using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Laimejimas : MonoBehaviour {
	// Use this for initialization
	public float health = 50f;
	private float timeris = 1f;

	// Update is called once per frame
		public void TakeDamage (float amount)
		{
			health -= amount;
			if (health <= 0f) {
				Die ();
			}
		}
		void Die ()
		{
			SceneManager.LoadScene(0);
		}
	void Update () {
		timeris += Time.deltaTime;
		PlayerPrefs.SetFloat ("HighScore", timeris);
		}
	}

