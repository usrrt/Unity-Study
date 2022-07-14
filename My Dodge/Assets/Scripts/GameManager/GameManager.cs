using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;


public class GameManager : MonoBehaviour
{
    // 게임매니저 역할
    // 1. 게임이 종료되면 게임오버 UI보여줌
    // 2. 재시작 안내를 해줌

    public TimerText Timer;
    public GameOverUi overUi;
    public LifePointText LifeUI;

    private bool _isOver;
    public PlayerLife _life;

    void Update()
    {
        // 만약 게임이 종료되었다면
        // R키를 눌렀다면 재시작
        if (/*_isOver && */Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0); // 빌드인덱스로 씬을 가져왔음
        }



        int health = _life.PlayerLifePoint;
        // 생명력 텍스트 출력
        LifeUI.LifePointUpdate(health);
        

    }

    public void End()
    {
        // 타이머 끄고
        Timer.IsPlayerAlive = false;

        // 타이머 데이터 저장
        int savedBestTime = PlayerPrefs.GetInt("BestTime", 0);
        int bestTime = Math.Max(Timer.SurvivalTime, savedBestTime);
        PlayerPrefs.SetInt("BestTime", bestTime);
        
        // GameOverUi갱신
        overUi.UpdateBestTime(bestTime);

        // 여기 실행
        _isOver = true;
    }








}
