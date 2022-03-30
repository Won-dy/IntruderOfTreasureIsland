using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour {

    public GameObject prefab; // Coin, uni 선택
    public Vector3 randomPosRange = Vector3.up;
    public Vector3 velocity = Vector3.left;

    public float offsetTime = 0f; // 처음 생성할 때까지 걸리는 시간
    public float intervalTime = 3f; // 생성되는 타이밍
    public float leftTime = 5f; // 사라지는 시간

    public float mTime = 0f; // 시간 관리
                             // Use this for initialization
    void Start()
    {
        mTime = -offsetTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (Game.instance.state != Game.STATE.MOVE)
        {
            return;
        }

        mTime += Time.deltaTime; // 프레임 시간 간격을 더한다. 
        if (mTime < 0f) return;
        if (mTime >= intervalTime) // 생성할 시간이 되었는지 검사
        {
            Vector3 randomPos = Vector3.one;
            randomPos.x = Random.Range(-randomPosRange.x, randomPosRange.x);
            randomPos.y = Random.Range(-randomPosRange.y, randomPosRange.y);

            Vector3 pos = transform.position + randomPos;
            GameObject obj = Instantiate(prefab, pos, transform.rotation) as GameObject;
            obj.GetComponent<Rigidbody2D>().velocity = velocity; // 캐릭터 이동
            Destroy(obj, leftTime);
            mTime = 0f;
        }
    }
}
