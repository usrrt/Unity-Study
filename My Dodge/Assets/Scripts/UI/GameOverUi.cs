using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOverUi : MonoBehaviour
{
    public TextMeshProUGUI _bestTimeUI;

    public void UpdateBestTime(int bestTime)
    {
        gameObject.SetActive(true);
        _bestTimeUI.text = $"최고 기록: {bestTime}초";

    }
}
