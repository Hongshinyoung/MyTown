using UnityEngine;

public class CameraTargetData : MonoBehaviour
{

    public CreatePlayerPrefab createPlayerPrefab;
    public CameraController cameraController;
    public void Start()
    {
        //플레이어 생성(Awake)니 Start로 조금 느리게 cameracontroller에 타겟 전달
        SetTargetData();
    }
    public void SetTargetData()
    {
        
        GameObject target = GameManager.Instance.PlayerList[0]; //플레이어는 1명이니
        if (target != null)
        {
            cameraController.SetTarget(target);
        }
    }
}
