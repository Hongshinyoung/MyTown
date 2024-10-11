using UnityEngine;

public class CreatePlayerPrefab:MonoBehaviour
{
    public Character character;
    public CameraController cameraController;

    private void Awake()
    {
        CreateCharacter();
    }

    public void CreateCharacter()
    {
        //플레이어가 있을 시, 기존 플레이어 파괴
        if(GameManager.Instance.PlayerList.Count > 0)
        {
            GameObject existingPlayer = GameManager.Instance.PlayerList[0];
            GameManager.Instance.RemovePlayer(existingPlayer);
            Destroy(existingPlayer);
        }


        //플레이어 resources경로에서 가져와서 프리팹 생성
        GameObject prefab = character.LoadCharacterPrefab();
        if (prefab != null)
        {
            GameObject obj = Instantiate(prefab);
           // obj.transform.position = GameManager.Instance.PlayerList[0].transform.position;
            GameManager.Instance.AddPlayer(obj); //플레이어가 생성되어, 리스트에 추가
            cameraController.SetTarget(obj);
        }

    }
}