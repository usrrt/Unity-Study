using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerText : MonoBehaviour
{
    public bool IsPlayerAlive {get; set;}
    public int SurvivalTime{get; private set;}

    private float _elapsedTime;
    private TextMeshProUGUI _ui; // 정체가뭐냐


    void Start()
    {
        _ui = GetComponent<TextMeshProUGUI>();
        _ui.text = $"시간: {SurvivalTime}초";
        IsPlayerAlive = true;

    }

    // Update is called once per frame
    void Update()
    {   
        if(IsPlayerAlive)
        {
            // 1초에 한 번씩만 업데이트 되도록?
            _elapsedTime += Time.deltaTime;
            if (_elapsedTime >= 1f)
            {            
                //SurvivalTime++;
                SurvivalTime += (int)_elapsedTime;
                _ui.text = $"시간: {SurvivalTime}초";
                _elapsedTime = 0;
            }
        }

    }
}
