using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CreatePlayerName: MonoBehaviour
{
    public InputField inputName;
    public static string playerName { get; private set; }

    public void SaveName()
    {
       playerName = inputName.text;
    }

}
