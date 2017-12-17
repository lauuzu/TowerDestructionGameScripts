using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IsokantisESCMenu : MonoBehaviour {
	public Canvas EscMenu;
	public Button resumetext;
	public Button quittext;
	// Use this for initialization
	void Start () {
		EscMenu = EscMenu.GetComponent<Canvas> ();
		resumetext = resumetext.GetComponent<Button> ();
		quittext = quittext.GetComponent<Button> ();
		EscMenu.enabled = false;


	}
	void Update () {
		if (Input.GetKeyUp (KeyCode.Escape)) {
		
			//EscMenu = EscMenu.GetComponent<Canvas> ();
			//resumetext = resumetext.GetComponent<Button> ();
			//quittext = quittext.GetComponent<Button> ();
			Time.timeScale = 0;
			EscMenu.enabled = true;
			resumetext.enabled = true;
			quittext.enabled = true;

		}
	}
	
	public void PressResume(){
		EscMenu.enabled = false;
		resumetext.enabled = false;
		quittext.enabled = false;
		Time.timeScale = 1;
	}
	public void PressQuit(){
		SceneManager.LoadScene (0);
		Time.timeScale = 1;
	}

}
