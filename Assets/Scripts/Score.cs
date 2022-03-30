using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {
    private static Score mInstance;  
    //싱글톤 : 프로그램 전체에서 하나만 사용하는 인스턴스
    public static Score instance
    {
        get
        {
            if (mInstance == null)
            {
                mInstance = FindObjectOfType<Score>();
            }
            return mInstance;
        }
    }
	// Use this for initialization
	void Start () {
        if (this != instance)
        {
            Destroy(this);
        }
	}
	public int score //읽기전용 프로퍼니 해당 스크립트에서만 호출되로독한다.
    {
        get;
        private set;
    }
    public void Add()
    {
        score+=300;
    }
    public void Reset()
    {
        score = 0;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
