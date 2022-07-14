using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LifePointText : MonoBehaviour
{
    public TextMeshProUGUI _lifePointUI;
    
    public void LifePointUpdate(int lifePoint)
    {
        _lifePointUI.text = $"남은 목숨: {lifePoint}";
    }

}
