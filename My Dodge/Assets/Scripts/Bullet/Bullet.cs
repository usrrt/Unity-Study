using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 2f);
    }
    public float BulletSpeed;
    void Update()
    {
        // 총알 발사방향을 플레이어쪽으로 발사한다


        // 총알이 로컬좌표기준으로 앞으로 나아간다
        transform.Translate(0f, 0f, BulletSpeed);

    }
    // private void OnTriggerEnter(Collider other)
    // {
    //     // // 컴포넌트를 가지고있는지 아닌지를 구별하는걸로 충돌판정가능
    //     // if(null == other.GetComponent<PlayerLife>())
    //     // {
    //     //     // other는 bullet이 아니다.
    //     // }

    //     // ?. 연산자
    //     // (expression)?. '' : expression이 null이 아니면 멤버에 접근함
    //     PlayerLife playerLife = other.GetComponent<PlayerLife>();
    //     playerLife?.Die();


    //     // tag구분
    //     if(other.tag == "Player")
    //     {
    //         other.GetComponent<PlayerLife>().Die();
    //     }
    // }
}
