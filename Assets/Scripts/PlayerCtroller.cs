using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))] //자동으로 스크립트로 컴포넌트 추가
public class PlayerCtroller : MonoBehaviour {
    public AudioClip jumpVoice;
    public AudioClip damageVoice; // CD
    private AudioSource mAudio; // CD 플레이어
    public static UnityChan2DController mUnityChan2D;
    public static Collider2D mCollider2D;

    // 중력 컨트롤
    public static Rigidbody2D rb;
    public float initGravityScale;  // 중력 초기값
   
    // 심장 소리 컨트롤
    public float interval = 1f;
    private float time;

    // 체력바
    public static int hp = 100;
    private int initHp;  // 생명 초기값
    public Image imgHpBar;

    // Use this for initialization
    void Start() {
        initHp = 100;
        hp = 100;

        mAudio = GetComponent<AudioSource>();
        mUnityChan2D = GetComponent<UnityChan2DController>();
        mCollider2D = GetComponent<Collider2D>();

        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = initGravityScale;
    }
    void OnDamage()
    {
        PlayerVoice(damageVoice);
        hp -= 25;
        Debug.Log("hp: " + hp);
        imgHpBar.fillAmount = (float)hp / (float)initHp;
        if (hp <= 0)
        {
            PlayerDie();
        }
    }
    void Jump()
    {
        PlayerVoice(jumpVoice);
    }
    void PlayerVoice(AudioClip clip)
    {
        mAudio.Stop();
        mAudio.PlayOneShot(clip); // 사운드가 중첩되서 실행이 가능함 
    }
    // Update is called once per frame
    void Update () {
        if (hp > 0 && hp <= 25)
        {
            time += Time.deltaTime;
            if (time >= interval)
            {
                time = 0f;
                SoundManager.instance.HeartSound();
            }
        } 
    }
    public static void PlayerDie()
    {
        Debug.Log("Die hp: " + hp);
        mCollider2D.enabled = false;
        mUnityChan2D.enabled = false;
        Game.instance.state = Game.STATE.GAMEOVER;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Potion")
        {
            hp += 20;
            if (hp >= 100)
            {
                hp = 100;
                Debug.Log("UPhp: " + hp);
                imgHpBar.fillAmount = (float)hp / (float)initHp;
            }
            else
            {
                Debug.Log("UPhp: " + hp);
                imgHpBar.fillAmount = (float)hp / (float)initHp;
            }
            SoundManager.instance.GetPotion();
            Destroy(collision.gameObject);
        }
    }
}
