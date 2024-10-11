using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Participant:MonoBehaviour
{
    private int playerCount;
    public Text PlayercountTxt;
    public Text[] playerName; //참여자 이름

    private void DisplayPlayerData()
    {
        playerCount = GameManager.Instance.PlayerCount;
        PlayercountTxt.text = "참여자:"+playerCount.ToString();
        for(int i = 0; i < playerCount; i++)
        {
            playerName[i].text = GameManager.Instance.PlayerList[i].name;
            playerName[0].text = CreatePlayerName.playerName; //플레이어가 첫번째로 표시
        }
        
    }

    private void FixedUpdate()
    {
        DisplayPlayerData();
    }
}