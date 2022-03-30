using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class Out : MonoBehaviour {
    private AudioSource mAudio;
    void Start()
    {
        mAudio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            mAudio.Play();
            PlayerCtroller.PlayerDie();
        }
    }
}
