using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int CharacterIndex;//캐릭터 인덱스

    public List<GameObject> PlayerList = new List<GameObject>();
    public int PlayerCount => PlayerList.Count;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else Destroy(gameObject);

        DontDestroyOnLoad(gameObject);

    }

    public void AddPlayer(GameObject player)
    {
        if (!PlayerList.Contains(player))
        {
            PlayerList.Add(player);
        }
    }

    public void RemovePlayer(GameObject player)
    {
        if(PlayerList.Contains(player))
        {
            PlayerList.Remove(player);
        }
    }


}