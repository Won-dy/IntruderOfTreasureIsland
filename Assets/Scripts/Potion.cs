using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class Potion : MonoBehaviour {
	private AudioSource mAudio;
	private Renderer mRenderer;
	private Collider2D mCollider2D;

	// Use this for initialization
	void Start () {
		mAudio = GetComponent<AudioSource>();
		mRenderer = GetComponent<Renderer>();
		mCollider2D = GetComponent<Collider2D>();
	}
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "Player")
		{
			//Score.instance.Add();
			Debug.Log("add hp: " + PlayerCtroller.hp);
			PlayerCtroller.hp += 20;
			//PlayerCtroller.imgHpBar.fillAmount = (float)PlayerCtroller.hp / (float)100;

			mRenderer.enabled = false;
			mCollider2D.enabled = false;
			mAudio.Play();
			Destroy(gameObject, mAudio.clip.length);
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
