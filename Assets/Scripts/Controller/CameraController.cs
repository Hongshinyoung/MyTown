using UnityEngine;

public class CameraController : MonoBehaviour
{
    Camera camera;
    public GameObject target;
    public float offsetZ = 10.0f;

    private void Awake()
    {
        camera = GetComponent<Camera>();
        camera = Camera.main;
    }

    public void SetTarget(GameObject player)
    {
        target = player;
    }

    private void FixedUpdate()
    {
        transform.position = target.transform.position - new Vector3(0,0,target.transform.position.z + offsetZ);
    }


}
