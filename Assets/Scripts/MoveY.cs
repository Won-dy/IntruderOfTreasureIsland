using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveY : MonoBehaviour {
	Vector3 nowPst;
	public float delta;  // 이동가능한 x의 최대값
	public float speed;  // 이동 속도

	// Use this for initialization
	void Start()
	{
		nowPst = transform.position; // 현재 위치
	}

	// Update is called once per frame
	void Update()
	{
		Vector3 vt = nowPst;
		vt.y += delta * Mathf.Sin(Time.time * speed);
		transform.position = vt;
	}
}
