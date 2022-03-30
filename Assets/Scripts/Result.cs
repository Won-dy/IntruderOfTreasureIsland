using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Result : MonoBehaviour {
	public GameObject parts;
	public GameObject checking;
	public GameObject btns;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (ReachGoal.goal)
		{  
			// 열쇠 모두 모았나 판별
			if (KeyCtrl.cntKey == 3)
			{
				SoundManager.instance.GoalSound();
				//parts.SetActive(true);
				//btns.SetActive(true);
				SceneManager.LoadScene("Ending");
			}
			else
			{
				SoundManager.instance.BeepSound();
				checking.SetActive(true);
				ReachGoal.goal = false;
				Debug.Log("Cancel Goal");
			}
		}
	}
}
