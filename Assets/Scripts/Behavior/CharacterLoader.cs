using UnityEngine;

public class CharacterLoader:MonoBehaviour
{
    public string[] characterPrefabNames; //프리팹 이름


    //캐릭터 프리팹 불러오기
    public GameObject LoadCharacterPrefab()
    {

        string prefabPath = $"Characters/{characterPrefabNames[GameManager.Instance.CharacterIndex]}";
        GameObject prefab = Resources.Load<GameObject>(prefabPath);

        if(prefab == null )
        {
            Debug.Log("경로에 없음");
            Debug.Log(prefabPath);
        }
        return prefab;
    }
}