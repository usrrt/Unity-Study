using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    public int PlayerLifePoint = 5;
    public GameManager gameManager;

    // 죽음 === 삭제
    public void Die()
    {
        // 오브젝트 삭제
        gameObject.SetActive(false);

        gameManager.End();

        //FindObjectOfType<GameManager>().End();
    }
    
    // 플레이어입장에서 처리
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Bullet"))
        {
            PlayerLifePoint--;
            if(PlayerLifePoint <= 0)
            {
                Die();
                Debug.Log("플레이어 사망");
            }
        }
    }

}
