using UnityEngine;

public class MyTownMovement: MonoBehaviour
{
    private MyTownController controller;

    private Rigidbody2D rigidbody;
    private CharacterStatHandler characterStatHandler;
    private Vector2 movementDirection = Vector2.zero;

    private void Awake()
    {
        controller = GetComponent<MyTownController>();
        rigidbody = GetComponent<Rigidbody2D>();
        characterStatHandler = GetComponent<CharacterStatHandler>();
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
        rigidbody.velocity = movementDirection * characterStatHandler.CurrentStats.speed;
    }

}
