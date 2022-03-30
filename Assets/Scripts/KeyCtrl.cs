using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyCtrl : MonoBehaviour {
	public static int cntKey;

	// Use this for initialization
	void Start () {
		cntKey = 0;
	}
	
	// Update is called once per frame
	void Update () {
		Text uiText = GetComponent<Text>();
		uiText.text = "X " + cntKey.ToString();

	}
}
