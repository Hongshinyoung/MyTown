using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController: MyTownController
{
    Camera camera;

    private void Awake()
    {
        camera = Camera.main;
    }

    private void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    private void OnLook(InputValue value)
    {
        Vector2 lookInput = value.Get<Vector2>();
        Vector2 worldPos = camera.ScreenToWorldPoint(lookInput);
        lookInput = (worldPos - (Vector2)transform.position).normalized;
        CallLookEvent(lookInput);
    }
}
