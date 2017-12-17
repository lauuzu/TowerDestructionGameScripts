using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Meniu : MonoBehaviour {
	public Canvas quitMenu;
	public Button startText;
	public Button Highscore;
	public Button OptionText;
	public Button ApieText;
	public Button exitText;
	public Canvas OptionsMenu;
	public Canvas AboutMenu;
	public Canvas HighScoreMenu;
	int HiscorasInt;

	public Slider reiksme;
	private float masterVolume;
	private float HighScore;
	public Text highscoras;
	// Use this for initialization
	void Start () {
		quitMenu = quitMenu.GetComponent<Canvas> ();
		quitMenu.enabled = false;
		startText = startText.GetComponent<Button> ();
		Highscore = Highscore.GetComponent<Button> ();
		OptionText = OptionText.GetComponent<Button> ();
		ApieText = ApieText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
		highscoras = highscoras.GetComponent<Text> ();
		OptionsMenu = OptionsMenu.GetComponent<Canvas> ();
		OptionsMenu.enabled = false;
		AboutMenu.enabled = AboutMenu.GetComponent<Canvas> ();
		AboutMenu.enabled = false;
		HighScoreMenu.enabled = HighScoreMenu.GetComponent<Canvas> ();
		HighScoreMenu.enabled = false;
		masterVolume = PlayerPrefs.GetFloat ("MasterVolume");
		reiksme.value = masterVolume;
		Time.timeScale = 1;


	}
	void Update()
	{
		HighScore = PlayerPrefs.GetInt ("Saudymas");
		highscoras.text = HighScore.ToString ("f0");
		if (masterVolume != reiksme.value) {
			masterVolume = reiksme.value;
			PlayerPrefs.SetFloat ("MasterVolume", masterVolume);
		}
		AudioListener.volume = masterVolume;
	}
	public void StartLevel()
	{
		SceneManager.LoadScene (1);

	}
	public void ExitGame()
	{
		Application.Quit ();

	}
	public void ExitPress()
	{
		quitMenu.enabled = true;
		startText.enabled = false;
		Highscore.enabled = false;
		OptionText.enabled = false;
		ApieText.enabled = false;
		exitText.enabled = false;
	}
	public void NoPress()
	{
		quitMenu.enabled = false;
		OptionsMenu.enabled = false;
		AboutMenu.enabled = false;
		HighScoreMenu.enabled = false;
		startText.enabled = true;
		Highscore.enabled = true;
		OptionText.enabled = true;
		ApieText.enabled = true;
		exitText.enabled = true;
	}
	public void OptionPress()
	{
		OptionsMenu.enabled = true;
		quitMenu.enabled = false;
		AboutMenu.enabled = false;
		startText.enabled = false;
		Highscore.enabled = false;
		OptionText.enabled = false;
		ApieText.enabled = false;
		exitText.enabled = false;
	
	}
	public void AboutPress()
	{
		OptionsMenu.enabled = false;
		quitMenu.enabled = false;
		AboutMenu.enabled = true;
		startText.enabled = false;
		Highscore.enabled = false;
		OptionText.enabled = false;
		ApieText.enabled = false;
		exitText.enabled = false;

	}
	public void HighPress()
	{
		HighScoreMenu.enabled = true;
		startText.enabled = false;
		Highscore.enabled = false;
		OptionText.enabled = false;
		ApieText.enabled = false;
		exitText.enabled = false;
	}

}

