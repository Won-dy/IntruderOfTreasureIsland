using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReachGoal : MonoBehaviour {
	public static bool goal;

	// Use this for initialization
	void Start () {
		goal = false;
	}
	private void OnTriggerEnter2D(Collider2D collision)
	{
			if (collision.tag == "Player")
			{
				goal = true;
				Debug.Log("Goal");
			}
	}
}
