using System;
using UnityEngine;

public class MyTownAimRotation:MonoBehaviour
{
    [SerializeField] private SpriteRenderer characterRenderer;
    [SerializeField] private Transform weaponPivot;
    [SerializeField] private SpriteRenderer weaponRenderer;

    private MyTownController controller;

    private void Awake()
    {
        controller = GetComponent<MyTownController>();
    }

    private void Start()
    {
        controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 direction)
    {
        RotateCharacter(direction);
    }

    private void RotateCharacter(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
        weaponPivot.rotation = Quaternion.Euler(0,0,rotZ);
    }
}
