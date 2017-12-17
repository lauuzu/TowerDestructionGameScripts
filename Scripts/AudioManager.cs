using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {
	
	float masterVolumePercent = 1;
	float sfxVolumePercent = 1;
	float musicVolumePercent = 1;

	AudioSource[] musicSources;
	int activeMusicSourceIndex;

	void Awake() {
		musicSources = new AudioSource[2];
		GameObject newMusicSource = new GameObject ("Music source " + (1));
		musicSources [1] = newMusicSource.AddComponent<AudioSource> ();
		newMusicSource.transform.parent = transform;
		//PlayerPrefs.SetFloat ("MasterVolume" );
		//masterVolumePercent = PlayerPrefs.GetFloat ("MasterVolume");
	}

	public void PlayMusic(AudioClip clip, float fadeDuration = 1){
		activeMusicSourceIndex = 1 - activeMusicSourceIndex;
		musicSources [activeMusicSourceIndex].clip = clip;
		musicSources [activeMusicSourceIndex].Play ();

		StartCoroutine (AnimateMusicCrossfade (fadeDuration));
	}
	public void PlaySound(AudioClip clip, Vector3 pos)	{
		AudioSource.PlayClipAtPoint (clip, pos, sfxVolumePercent * masterVolumePercent);
	}
	IEnumerator AnimateMusicCrossfade(float duration) {
		float percent = 0;

		while (percent < 1) {
			percent += Time.deltaTime * 1 / duration;
			musicSources [activeMusicSourceIndex].volume = Mathf.Lerp (0, musicVolumePercent * masterVolumePercent, percent);
			musicSources [1-activeMusicSourceIndex].volume = Mathf.Lerp (musicVolumePercent * masterVolumePercent, 0, percent);
			yield return null;
		}
	}
}
