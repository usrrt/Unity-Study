using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject BulletPerfab;
    public Transform Player;

    public float randomCheck;
    public float minRange;
    public float maxRange;

    // Start is called before the first frame update
    void Start()
    {
        // minRange = 0.5f;
        // maxRange = 1f;
        randomCheck = Random.Range(minRange, maxRange);
        
    }
    

    private float _elapsedTime;
    // Update is called once per frame
    void Update()
    {
        // 0.5초관련 디버그찍기
        // 유니티 시간관련 기능 Time사용
        _elapsedTime += Time.deltaTime;
        if(_elapsedTime >= randomCheck)
        {
            randomCheck = Random.Range(minRange, maxRange);
            _elapsedTime = 0f;

            //Vector3 spawnPosition = transform.position + new Vector3(0f, 0f, 1f);

            // 위치값을 tag "BulletSpawner"
            GameObject bullet = Instantiate(BulletPerfab, transform);
            bullet.transform.LookAt(Player);
        }
    }
}
