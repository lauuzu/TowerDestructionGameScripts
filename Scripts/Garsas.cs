using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Garsas : MonoBehaviour {
	private float masterVolume;
	// Use this for initialization
	void Start () {
		masterVolume = PlayerPrefs.GetFloat ("MasterVolume");
		AudioListener.volume = masterVolume;
	}

}
