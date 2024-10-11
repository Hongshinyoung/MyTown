using UnityEngine;
using UnityEngine.UI;

public class PlayerNameTag:MonoBehaviour
{

    public Text playerNameText;
    public GameObject PlayerNameObj;

    public void Awake()
    {
        PlayerNameObj.SetActive(true);
    }

    private void DisplayNameTag()
    {
        playerNameText.text = CreatePlayerName.playerName;
    }

    private void Update()
    {
        DisplayNameTag();
    }
}