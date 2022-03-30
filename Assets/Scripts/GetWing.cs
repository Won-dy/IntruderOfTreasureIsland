using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetWing : MonoBehaviour {
	private Rigidbody2D rb;
	public float addGrvtScl;
	public float initGrvtScl;  // 중력 초기값

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		rb.gravityScale = initGrvtScl;
	}
	/*void OnColliderEnter2D(Collision target)
	{
		if (target.collider.CompareTag("Wing"))
		{
			rb.gravityScale += addGrvtScl;
			Debug.Log("GetWing");
		}
	}*/
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "Wing")
		{
			rb.gravityScale += addGrvtScl;
			Debug.Log("GetWing");
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
