using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {
	public AudioClip soundPotion, soundHeart, soundBtnClick, soundBeep, soundGoal;
	AudioSource myAudio;
	public static SoundManager instance;
	void Awake()
	{
		if (SoundManager.instance == null)
			SoundManager.instance = this;
	}
	void Start () {
		myAudio = GetComponent<AudioSource>();
	}
	public void GetPotion()
	{
		myAudio.PlayOneShot(soundPotion);
	}
	public void HeartSound()
	{
		myAudio.PlayOneShot(soundHeart);
	}
	public void BtnClickSound()
	{
		myAudio.PlayOneShot(soundBtnClick);
	}
	public void BeepSound()
	{
		myAudio.PlayOneShot(soundBeep);
	}
	public void GoalSound()
	{
		myAudio.PlayOneShot(soundGoal);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
