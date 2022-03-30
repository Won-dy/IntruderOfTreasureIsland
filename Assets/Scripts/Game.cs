using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour {
    public GameObject btns2;

    private static Game mInstance;
    public static Game instance
    {
        get {
            if (mInstance == null)
            {
                mInstance = FindObjectOfType<Game>();
            }
            return mInstance;

        }
    }
    public enum STATE
    {
        NONE,
        START,
        MOVE,
        GAMEOVER
    };
    public STATE state
    {
        get;
        set;
    }
    private Text mText;
	// Use this for initialization
	void Start () {
        mText = GetComponent<Text>();
        state = STATE.START;
        StartCoroutine("StartCountDown");
	}
	
	// Update is called once per frame
	void Update () {
        switch (state)
        {
            case STATE.START: break;
            case STATE.MOVE: break;
            case STATE.GAMEOVER:
                mText.text = "Game Over";
                btns2.SetActive(true);
                if (Input.GetButtonDown("Jump"))
                {
                    int currentScene = Application.loadedLevel;
                    Application.LoadLevel(currentScene);
                }
                break;
        }
	}
    IEnumerator StartCountDown()
    {
        mText.text = "FIND 3 KEY";
        yield return new WaitForSeconds(1.5f);
        mText.text = "";
        state = STATE.MOVE;
    }
}
