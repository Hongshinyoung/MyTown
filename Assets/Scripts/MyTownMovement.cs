using UnityEngine;

public class MyTownMovement: MonoBehaviour
{
    private MyTownController controller;
    private Rigidbody2D rigidbody;
    private Vector2 movementDirection = Vector2.zero;
    private float speed;

    private void Awake()
    {
        controller = GetComponent<MyTownController>();
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }

    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);
    }

    private void ApplyMovement(Vector2 direction)
    {
        movementDirection *= speed;
        rigidbody.velocity = movementDirection;
    }

}
