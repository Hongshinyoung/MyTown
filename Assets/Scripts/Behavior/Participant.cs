using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Participant:MonoBehaviour
{
    private int playerCount;
    public Text PlayercountTxt;
    public Text[] playerName; //������ �̸�

    private void DisplayPlayerData()
    {
        playerCount = GameManager.Instance.PlayerCount;
        PlayercountTxt.text = "������:"+playerCount.ToString();
        for(int i = 0; i < playerCount; i++)
        {
            playerName[i].text = GameManager.Instance.PlayerList[i].name;
            playerName[0].text = CreatePlayerName.playerName; //�÷��̾ ù��°�� ǥ��
        }
        
    }

    private void FixedUpdate()
    {
        DisplayPlayerData();
    }
}