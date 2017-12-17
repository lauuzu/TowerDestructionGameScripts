using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	private float timeris = 180f;
	private Text timerSeconds;
	// Use this for initialization
	void Start () {
		timerSeconds = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		timeris -= Time.deltaTime;
		timerSeconds.text = timeris.ToString("f2");
		if (timeris <=0){
			SceneManager.LoadScene (0);
		}
	}
}
