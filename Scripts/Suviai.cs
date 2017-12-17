using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Suviai : MonoBehaviour {

	// Use this for initialization
	public int suviai;
	private Text ShotsMade;
	void Start () {
		ShotsMade = GetComponent<Text>();
		
	}
	
	// Update is called once per frame
	void Update () {
		suviai = PlayerPrefs.GetInt ("Saudymas",999);
		ShotsMade.text = suviai.ToString ("f0");

		
	}
}